using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace StegoPrograma
{
    public partial class Form1 : Form
    {
        Bitmap img;
        byte[] data;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = ofdImagen.FileName;
                img = new Bitmap(txtImagen.Text);
            }
            lblCapacidad.Text = "Capadidad máxima del caracteres: " + (((img.Height * img.Width) - 1) / 3);
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            if (ofdTexto.ShowDialog() == DialogResult.OK)
            {
                txtTexto.Text = ofdTexto.FileName;
                using (FileStream fs = File.OpenRead(txtTexto.Text))
                {
                    data = new BinaryReader(fs).ReadBytes((int)fs.Length);               
                }
                rtbTextoOculto.Text = Encoding.UTF8.GetString(data);
            }
        }

        private void btnImagen2_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen2.Text = ofdImagen.FileName;
                img = new Bitmap(txtImagen2.Text);
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {

            //string path = txtTexto.Text;
            //Bitmap img = new Bitmap(txtImagen.Text);
            //img = new Bitmap(txtImagen.Text);
            //byte[] data;
            int indice = 0, bit = 0;
            int rojo = 0, verde = 0, azul = 0;
            byte[] arr_letra_bits = new byte[8];
            bool terminado = false;
            /*using (FileStream fs = File.OpenRead(path))
            {
                data = new BinaryReader(fs).ReadBytes((int)fs.Length);
            }*/

            //data.[data.Length] = 255;
            
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (bit == 0 && indice < data.Length)
                    {
                        arr_letra_bits = obtener_bits(data[indice]);//La letra en bits
                        Console.WriteLine("Ingresando {0} ", Convert.ToChar(data[indice]));
                    }
                    else if (bit == 0 && indice == data.Length)
                    {
                        arr_letra_bits = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };//La letra en bits
                        Console.WriteLine("Ingresando Char Final");
                    }
                    else if(indice > data.Length)
                    {
                        Console.WriteLine("Finalizado");
                        terminado = true;
                        break;
                    }
                       
                    Color pixel = img.GetPixel(i, j);
                    Console.WriteLine("Pixel Antes {0}-{1}: {2}, {3}, {4}", i, j, pixel.R, pixel.G, pixel.B);

                    #region LBS Rojo
                    if (bit < arr_letra_bits.Length)
                    {
                        rojo = modificar_color(pixel, 'R', arr_letra_bits[bit]);
                        bit++;
                    }
                    else
                    {
                        bit = 0;
                    }
                    #endregion

                    #region LBS VERDE
                    if (bit < arr_letra_bits.Length)
                    {
                        verde = modificar_color(pixel, 'G', arr_letra_bits[bit]);
                        bit++;
                    }
                    else
                    {
                        bit = 0;
                    }
                    #endregion

                    #region LBS AZUL
                    if (bit < arr_letra_bits.Length)
                    {
                        azul = modificar_color(pixel, 'B', arr_letra_bits[bit]);
                        bit++;
                    }
                    else
                    {
                        indice++;
                        bit = 0;
                        azul = pixel.B;
                    }
                    #endregion

                    Console.WriteLine("Pixel Despues {0}-{1}: {2}, {3}, {4}", i, j, rojo, verde, azul);
                   
                    img.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));//Ingreso del pixel modificado en la imagen                  
                }

                if (terminado)
                    break;
            }
            Console.WriteLine("Todo ok");

            string pathEncoded = "";
            if (sfdOcultar.ShowDialog() == DialogResult.OK)
            {
                pathEncoded = sfdOcultar.FileName;
                img.Save(pathEncoded);
            }

            Console.WriteLine("Guardado");
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Bitmap img = new Bitmap(txtImagen2.Text);
            string mensaje = "", cadena_bytes = "", cadena_anterior = "";
            byte rojo = 0, verde = 0, azul = 0;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    ///Char de finalizacion 
                    if (cadena_anterior.Equals("11111111"))
                        break;
                    Color pixel = img.GetPixel(i, j);
                    Console.WriteLine("Pixel Antes {0}-{1}: {2}, {3}, {4}", i, j, pixel.R, pixel.G, pixel.B);
                    rojo = obtener_ultimo_bit(pixel, 'R');
                    cadena_bytes += rojo;

                    verde = obtener_ultimo_bit(pixel, 'G');
                    cadena_bytes += verde;

                    if (cadena_bytes.Length >= 8)
                    {
                        cadena_anterior = cadena_bytes;    
                        if (cadena_anterior.Equals("11111111"))
                            continue;
                        else 
                            mensaje += obtener_letra(cadena_bytes);
                        cadena_bytes = "";

                    }
                    else 
                    {
                        azul = obtener_ultimo_bit(pixel, 'B');
                        cadena_bytes += azul;
                    }   
                }
                if (cadena_anterior.Equals("11111111"))
                    break;
            }
            rtbRecuperar.Text = mensaje;
        }

        public int modificar_color(Color pixel, char color, byte bit)
        {
            /**Se pasa 3 parametros: el pixel, el color a cambiar y el bit que se va a cambiar.
            Devuelve el color trasformado en entero.
            Una vez que identifica el color a cambiar hace un arreglo que contiene bits y 
            finalmente se hace el cambio del ultimo bit y retorna el binario ya trasformado.*/

            byte[] cambio_color = new byte[8];
            if (color.Equals('R'))
                cambio_color = obtener_bits((byte)pixel.R);
            else if (color.Equals('G'))
                cambio_color = obtener_bits((byte)pixel.G);
            else if (color.Equals('B'))
                cambio_color = obtener_bits((byte)pixel.B);

            cambio_color[7] = bit;

            int nuevo_color = Convert.ToInt32(obtener_byte(cambio_color));
            return nuevo_color;
        }

        public byte[] obtener_bits(byte valor)
        {
            /**Se pasa 1 parametro: el byte del pixel.
            Devuelve un arreglo de bits.
            Trasforma el byte en bits y lo pone en un arreglo de bytes.*/
            BitArray arr_bits = new BitArray(new byte[] { valor });
            bool[] arr_booleanos = new bool[arr_bits.Count];
            arr_bits.CopyTo(arr_booleanos, 0);
            byte[] bitsArray = arr_booleanos.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);

            return bitsArray;
        }

        public byte obtener_byte(byte[] bits)
        {
            /**Se pasa 1 parametro: el arreglo de bits.
             Devuelve un byte en forma de entero
            Convierte el arreglo de bits en una cadena que será luego
            trasformada en un byte*/
            string cadena_bits = "";
            for (int i = 0; i < bits.Length; i++)
                cadena_bits += bits[i];
            byte bits_unidos = Convert.ToByte(cadena_bits, 2);
            return bits_unidos;
        }

        public byte obtener_ultimo_bit(Color pixel, char color)
        {
            /**Se pasa 2 parametros: el pixel y el color a operar.
            Devuelve un bit del arreglo de byte
            Verifica cual color se esta trabajando y en base a ese 
            obtiene un arreglo de bits*/
            byte[] arr_bytes = new byte[8];
            if (color.Equals('R'))
                arr_bytes = obtener_bits((byte)pixel.R);
            else if (color.Equals('G'))
                arr_bytes = obtener_bits((byte)pixel.G);
            else if (color.Equals('B'))
                arr_bytes = obtener_bits((byte)pixel.B);

            return arr_bytes[7];
        }

        public string obtener_letra(string cadena)
        {
            /**Se pasa 1 parametro: un string que contiene un binario.
            Devuelve el caracter asociado con el binario
            Convierte el string para luego convertirlo en un caracter*/
            byte[] bytes = new byte[1];

            bytes[0] = Convert.ToByte(cadena, 2);

            string resultado = Encoding.UTF8.GetString(bytes);
            return resultado;
        }
    }
}
