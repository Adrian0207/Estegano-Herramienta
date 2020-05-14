namespace StegoPrograma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rtbTextoOculto = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.txtImagen2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbRecuperar = new System.Windows.Forms.RichTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.ofdTexto = new System.Windows.Forms.OpenFileDialog();
            this.sfdOcultar = new System.Windows.Forms.SaveFileDialog();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCapacidad);
            this.tabPage1.Controls.Add(this.btnTexto);
            this.tabPage1.Controls.Add(this.btnImagen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtImagen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTexto);
            this.tabPage1.Controls.Add(this.rtbTextoOculto);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnOcultar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ocultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(30, 138);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(75, 23);
            this.btnTexto.TabIndex = 13;
            this.btnTexto.Text = "Buscar";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(30, 67);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "Buscar";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imagen";
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Location = new System.Drawing.Point(130, 68);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(294, 22);
            this.txtImagen.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(130, 139);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(294, 22);
            this.txtTexto.TabIndex = 3;
            // 
            // rtbTextoOculto
            // 
            this.rtbTextoOculto.EnableAutoDragDrop = true;
            this.rtbTextoOculto.Location = new System.Drawing.Point(30, 179);
            this.rtbTextoOculto.Name = "rtbTextoOculto";
            this.rtbTextoOculto.ReadOnly = true;
            this.rtbTextoOculto.Size = new System.Drawing.Size(394, 208);
            this.rtbTextoOculto.TabIndex = 2;
            this.rtbTextoOculto.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(179, 477);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(99, 34);
            this.btnOcultar.TabIndex = 0;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnImagen2);
            this.tabPage2.Controls.Add(this.txtImagen2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rtbRecuperar);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.btnRecuperar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Imagen";
            // 
            // btnImagen2
            // 
            this.btnImagen2.Location = new System.Drawing.Point(38, 72);
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.Size = new System.Drawing.Size(75, 23);
            this.btnImagen2.TabIndex = 21;
            this.btnImagen2.Text = "Buscar";
            this.btnImagen2.UseVisualStyleBackColor = true;
            this.btnImagen2.Click += new System.EventHandler(this.btnImagen2_Click);
            // 
            // txtImagen2
            // 
            this.txtImagen2.Location = new System.Drawing.Point(138, 72);
            this.txtImagen2.Name = "txtImagen2";
            this.txtImagen2.Size = new System.Drawing.Size(294, 22);
            this.txtImagen2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contraseña";
            // 
            // rtbRecuperar
            // 
            this.rtbRecuperar.EnableAutoDragDrop = true;
            this.rtbRecuperar.Location = new System.Drawing.Point(38, 229);
            this.rtbRecuperar.Name = "rtbRecuperar";
            this.rtbRecuperar.ReadOnly = true;
            this.rtbRecuperar.Size = new System.Drawing.Size(394, 277);
            this.rtbRecuperar.TabIndex = 14;
            this.rtbRecuperar.Text = "";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 113);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 22);
            this.textBox6.TabIndex = 13;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(175, 171);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(99, 34);
            this.btnRecuperar.TabIndex = 12;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            this.ofdImagen.Filter = "PNG Files|*.png|GIF Files|*.gif";
            // 
            // ofdTexto
            // 
            this.ofdTexto.FileName = "openFileDialog1";
            this.ofdTexto.Filter = "TXT Files|*.txt";
            // 
            // sfdOcultar
            // 
            this.sfdOcultar.Filter = "PNG Files|*.png|GIF Files|*.gif";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.ForeColor = System.Drawing.Color.Crimson;
            this.lblCapacidad.Location = new System.Drawing.Point(35, 443);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(0, 17);
            this.lblCapacidad.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "StegoPro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RichTextBox rtbTextoOculto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.TextBox txtImagen2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbRecuperar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.OpenFileDialog ofdTexto;
        private System.Windows.Forms.SaveFileDialog sfdOcultar;
        private System.Windows.Forms.Label lblCapacidad;
    }
}

