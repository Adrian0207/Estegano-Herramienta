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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCapacidadTotal = new System.Windows.Forms.Label();
            this.lblCapacidadTexto = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblCapacidadImagen = new System.Windows.Forms.Label();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rtbTextoOculto = new System.Windows.Forms.RichTextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.txtImagen2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbRecuperar = new System.Windows.Forms.RichTextBox();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.ofdTexto = new System.Windows.Forms.OpenFileDialog();
            this.sfdOcultar = new System.Windows.Forms.SaveFileDialog();
            this.pgbRecuperar = new System.Windows.Forms.ProgressBar();
            this.pgbOcultar = new System.Windows.Forms.ProgressBar();
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
            this.tabControl1.Size = new System.Drawing.Size(478, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pgbOcultar);
            this.tabPage1.Controls.Add(this.lblCapacidadTotal);
            this.tabPage1.Controls.Add(this.lblCapacidadTexto);
            this.tabPage1.Controls.Add(this.btnGenerar);
            this.tabPage1.Controls.Add(this.lblCapacidadImagen);
            this.tabPage1.Controls.Add(this.btnTexto);
            this.tabPage1.Controls.Add(this.btnImagen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtImagen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblContra);
            this.tabPage1.Controls.Add(this.txtTexto);
            this.tabPage1.Controls.Add(this.rtbTextoOculto);
            this.tabPage1.Controls.Add(this.txtContra);
            this.tabPage1.Controls.Add(this.btnOcultar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ocultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCapacidadTotal
            // 
            this.lblCapacidadTotal.AutoSize = true;
            this.lblCapacidadTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblCapacidadTotal.Location = new System.Drawing.Point(27, 469);
            this.lblCapacidadTotal.Name = "lblCapacidadTotal";
            this.lblCapacidadTotal.Size = new System.Drawing.Size(107, 17);
            this.lblCapacidadTotal.TabIndex = 17;
            this.lblCapacidadTotal.Text = "CapacidadTotal";
            // 
            // lblCapacidadTexto
            // 
            this.lblCapacidadTexto.AutoSize = true;
            this.lblCapacidadTexto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCapacidadTexto.Location = new System.Drawing.Point(33, 157);
            this.lblCapacidadTexto.Name = "lblCapacidadTexto";
            this.lblCapacidadTexto.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidadTexto.TabIndex = 16;
            this.lblCapacidadTexto.Text = "Capacidad";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(226, 432);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 31);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblCapacidadImagen
            // 
            this.lblCapacidadImagen.AutoSize = true;
            this.lblCapacidadImagen.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCapacidadImagen.Location = new System.Drawing.Point(33, 72);
            this.lblCapacidadImagen.Name = "lblCapacidadImagen";
            this.lblCapacidadImagen.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidadImagen.TabIndex = 14;
            this.lblCapacidadImagen.Text = "Capacidad";
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(30, 124);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(75, 23);
            this.btnTexto.TabIndex = 13;
            this.btnTexto.Text = "Buscar";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(30, 40);
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
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione la Imagen";
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Location = new System.Drawing.Point(130, 41);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(294, 22);
            this.txtImagen.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el Texto";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblContra.Location = new System.Drawing.Point(88, 413);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(81, 17);
            this.lblContra.TabIndex = 5;
            this.lblContra.Text = "Contraseña";
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(130, 125);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(294, 22);
            this.txtTexto.TabIndex = 3;
            // 
            // rtbTextoOculto
            // 
            this.rtbTextoOculto.EnableAutoDragDrop = true;
            this.rtbTextoOculto.Location = new System.Drawing.Point(37, 181);
            this.rtbTextoOculto.Name = "rtbTextoOculto";
            this.rtbTextoOculto.ReadOnly = true;
            this.rtbTextoOculto.Size = new System.Drawing.Size(400, 230);
            this.rtbTextoOculto.TabIndex = 2;
            this.rtbTextoOculto.Text = "";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(85, 437);
            this.txtContra.Name = "txtContra";
            this.txtContra.ReadOnly = true;
            this.txtContra.Size = new System.Drawing.Size(123, 22);
            this.txtContra.TabIndex = 1;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Enabled = false;
            this.btnOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar.Location = new System.Drawing.Point(175, 504);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(100, 31);
            this.btnOcultar.TabIndex = 0;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pgbRecuperar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnImagen2);
            this.tabPage2.Controls.Add(this.txtImagen2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rtbRecuperar);
            this.tabPage2.Controls.Add(this.txtContra2);
            this.tabPage2.Controls.Add(this.btnRecuperar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Seleccione la Imagen";
            // 
            // btnImagen2
            // 
            this.btnImagen2.Location = new System.Drawing.Point(38, 52);
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.Size = new System.Drawing.Size(75, 23);
            this.btnImagen2.TabIndex = 21;
            this.btnImagen2.Text = "Buscar";
            this.btnImagen2.UseVisualStyleBackColor = true;
            this.btnImagen2.Click += new System.EventHandler(this.btnImagen2_Click);
            // 
            // txtImagen2
            // 
            this.txtImagen2.Enabled = false;
            this.txtImagen2.Location = new System.Drawing.Point(138, 52);
            this.txtImagen2.Name = "txtImagen2";
            this.txtImagen2.Size = new System.Drawing.Size(294, 22);
            this.txtImagen2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contraseña";
            // 
            // rtbRecuperar
            // 
            this.rtbRecuperar.EnableAutoDragDrop = true;
            this.rtbRecuperar.Location = new System.Drawing.Point(37, 240);
            this.rtbRecuperar.Name = "rtbRecuperar";
            this.rtbRecuperar.ReadOnly = true;
            this.rtbRecuperar.Size = new System.Drawing.Size(400, 344);
            this.rtbRecuperar.TabIndex = 14;
            this.rtbRecuperar.Text = "";
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(138, 93);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(148, 22);
            this.txtContra2.TabIndex = 13;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Enabled = false;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(165, 139);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(121, 32);
            this.btnRecuperar.TabIndex = 12;
            this.btnRecuperar.Text = "Recuperar\r\n";
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
            // pgbRecuperar
            // 
            this.pgbRecuperar.Location = new System.Drawing.Point(37, 195);
            this.pgbRecuperar.Name = "pgbRecuperar";
            this.pgbRecuperar.Size = new System.Drawing.Size(395, 29);
            this.pgbRecuperar.TabIndex = 23;
            // 
            // pgbOcultar
            // 
            this.pgbOcultar.Location = new System.Drawing.Point(37, 551);
            this.pgbOcultar.Name = "pgbOcultar";
            this.pgbOcultar.Size = new System.Drawing.Size(395, 29);
            this.pgbOcultar.Step = 1;
            this.pgbOcultar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 660);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StegoPUCE";
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
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RichTextBox rtbTextoOculto;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.TextBox txtImagen2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbRecuperar;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.OpenFileDialog ofdTexto;
        private System.Windows.Forms.SaveFileDialog sfdOcultar;
        private System.Windows.Forms.Label lblCapacidadImagen;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblCapacidadTexto;
        private System.Windows.Forms.Label lblCapacidadTotal;
        private System.Windows.Forms.ProgressBar pgbOcultar;
        private System.Windows.Forms.ProgressBar pgbRecuperar;
    }
}

