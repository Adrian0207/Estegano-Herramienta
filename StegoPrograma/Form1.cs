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

namespace StegoPrograma
{
    public partial class Form1 : Form
    {
        Bitmap img;
        byte[] data, arr_contra;
        double tamaImg = 0, tamaText = 0;
        public Form1()
        {
            InitializeComponent();
            btnTexto.Enabled = false;
            btnGenerar.Enabled = false;
            btnOcultar.Enabled = false;
            btnRecuperar.Enabled = false;
            btnOcultar.Enabled = false;
            lblCapacidadImagen.Text = "";
            lblCapacidadTexto.Text = "";
            lblCapacidadTotal.Text = "";
            lblContra.Text = "";
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = ofdImagen.FileName;
                img = new Bitmap(txtImagen.Text);
                double temp_tama = img.Height * img.Width;
                tamaImg = Math.Round((temp_tama - 15)/3,0) - 1;
                lblCapacidadImagen.Text = "Capadidad máxima de la Imagen: " + tamaImg + " caracteres";
                btnTexto.Enabled = true;
                btnGenerar.Enabled = true;

                if (tamaImg < tamaText )
                {
                    btnOcultar.Enabled = false;
                    btnGenerar.Enabled = false;
                    lblCapacidadTotal.Text = "El texto supera en " + (tamaText - tamaImg) + " caracteres a la imagen.\nPor favor cambien de texto para continuar.";
                }
                else
                {
                    btnGenerar.Enabled = true;
                    lblCapacidadTotal.Text = "";
                    lblContra.Text = "Genere la contraseña";
                }
            }
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            if (ofdTexto.ShowDialog() == DialogResult.OK)
            {
                txtTexto.Text = ofdTexto.FileName;
                using (FileStream fs = File.OpenRead(txtTexto.Text))
                {
                    data = new BinaryReader(fs).ReadBytes((int)fs.Length);//obtenemos el texto como un arreglo de bytes             
                }
                tamaText = data.Length;
                lblCapacidadTexto.Text = "Longitud del Texto: " + tamaText + " caracteres";
                rtbTextoOculto.Text = Encoding.UTF8.GetString(data);

                if(tamaImg < tamaText)
                {
                    btnOcultar.Enabled = false;
                    btnGenerar.Enabled = false;
                    lblCapacidadTotal.Text = "El texto supera en " + (tamaText - tamaImg) +" caracteres a la imagen.\nPor favor cambien de texto para continuar.";
                }
                else 
                {
                    btnGenerar.Enabled = true;
                    lblCapacidadTotal.Text = "";
                    lblContra.Text = "Genere la contraseña";
                }
            }
        }

        private void btnImagen2_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen2.Text = ofdImagen.FileName;
                img = new Bitmap(txtImagen2.Text);
                btnRecuperar.Enabled = true;
            }
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generar_contra();
            btnOcultar.Enabled = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            /**Indice se usa para el indice de los de los caracteres en binario
             Bit se usa para insertar los bits en la imagen*/

            /*Variables:
             Enteros: indice de la contraseña, indice de la data/mensaje, indice de bits del caracter
             Entero: color rojo, verde, azul          
             Booleanos: terminado del mensaje
             Byte: arreglo para caracter en bits
             Byte: arreglo de caracter con la contraseña, texto y el caracter final en bits*/
            int bit = 0, indice = 0;
            int rojo = 0, verde = 0, azul = 0;     
            bool terminado = false;
            byte[] arr_bits_char = new byte[8];
            byte[] info = arr_contra.Concat(data).Concat(new byte[] {255}).ToArray();//255 representa el codigo 255 en ASCII
                
            #region Ocultamiento
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (bit == 0 && indice < info.Length)
                    {
                        arr_bits_char = obtener_bits(info[indice]);
                        indice++;
                    }
                    else if (bit == 0 && indice == info.Length)
                    {
                        terminado = true;
                        break;
                    }
                    
                    Color pixel = img.GetPixel(i, j);

                    #region LBS Rojo
                    rojo = modificar_color(pixel, 'R', arr_bits_char[bit]);
                    bit++;
                    #endregion

                    #region LBS VERDE
                    verde = modificar_color(pixel, 'G', arr_bits_char[bit]);
                    bit++;
                    #endregion

                    #region LBS AZUL
                    if (bit < arr_bits_char.Length)
                    {
                        azul = modificar_color(pixel, 'B', arr_bits_char[bit]);
                        bit++;
                    }
                    else
                    {                      
                        bit = 0;
                        azul = pixel.B;
                    }
                    #endregion

                    img.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));//Ingreso del pixel modificado en la imagen                  
                }

                if (terminado)
                {
                    string mensaje = "La información se ha ocultado existosamente.\nPor favor selecione donde se guardará el archivo";
                    DialogResult dr = MessageBox.Show(mensaje, "Oculto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                    
            }
            #endregion

            string pathEncoded = "";
            if (sfdOcultar.ShowDialog() == DialogResult.OK)
            {
                pathEncoded = sfdOcultar.FileName;
                img.Save(pathEncoded);    
            }

            //Console.WriteLine("Guardado");
            txtImagen.Text = "";
            txtContra.Text = "";
            txtTexto.Text = "";
            lblCapacidadImagen.Text = "";
            lblCapacidadTexto.Text = "";
            btnTexto.Enabled = false;
            btnGenerar.Enabled = false;
            btnOcultar.Enabled = false;
            rtbTextoOculto.Text = "";
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            List<byte> lista_bytes = new List<byte>();
            string cadena_bytes = "", cadena_anterior = "", cadena_final = "11111111";
            byte rojo = 0, verde = 0, azul = 0;
            bool finalizo = false, todoOk = false;
            DialogResult dr;

            if (txtContra2.Text.Equals(""))
                dr = MessageBox.Show("Ingrese la contraseña", "Falta la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);

                        rojo = obtener_ultimo_bit(pixel, 'R');
                        cadena_bytes += rojo;

                        verde = obtener_ultimo_bit(pixel, 'G');
                        cadena_bytes += verde;

                        if (cadena_bytes.Length < 8)
                        {
                            azul = obtener_ultimo_bit(pixel, 'B');
                            cadena_bytes += azul;
                            
                        }
                        else if (cadena_bytes.Length == 8)
                        {
                            cadena_anterior = cadena_bytes;
                            if (cadena_anterior.Equals(cadena_final))
                            {
                                finalizo = true;
                                break;
                            }

                            else
                                // Convierte el string para luego convertirlo en un caracter y guardarlo en la lista
                                lista_bytes.Add(Convert.ToByte(cadena_bytes, 2));
                            cadena_bytes = "";
                        } 

                        if (i == 0 && j == 14)//14 es el espacio reservado para la contraseña
                        {
                            //Comparacion de cadenas de contraseñas
                            if (Encoding.UTF8.GetString(lista_bytes.ToArray()).Equals(txtContra2.Text))
                            {
                                lista_bytes = new List<byte>();
                                todoOk = true;
                            }
                            
                            else
                            {
                                string mensaje = "La contraseña no es válida.";
                                dr = MessageBox.Show(mensaje, "Error al Recuperar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                finalizo = true;
                                break;
                            }
                        }
                    }
                    if (finalizo)
                        break;
                }

            if (todoOk)
            {
                string mensaje = "La información se ha recuperado existosamente.";     
                rtbRecuperar.Text = Encoding.UTF8.GetString(lista_bytes.ToArray());
                dr = MessageBox.Show(mensaje, "Recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContra2.Text = "";
                txtImagen2.Text = "";
                btnRecuperar.Enabled = false;
            }
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

        public void generar_contra()
        {
            Random r = new Random();
            arr_contra = new byte[5];

            for (int i = 0; i < arr_contra.Length; i++)
            {
                if (r.Next(0, 10) % 2 == 0)
                    arr_contra[i] = Convert.ToByte(r.Next(49, 58));//obtenemos la contraseña en bytes
                else
                    arr_contra[i] = Convert.ToByte(r.Next(97, 123));//obtenemos la contraseña en bytes
            }
            txtContra.Text = Encoding.UTF8.GetString(arr_contra);
        }
    }
}
