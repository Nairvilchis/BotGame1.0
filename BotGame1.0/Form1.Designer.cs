using System;

namespace BotGame1._0
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.rtPalabra = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pbCrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Capturar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(159, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(388, 375);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            // 
            // rtPalabra
            // 
            this.rtPalabra.Location = new System.Drawing.Point(12, 128);
            this.rtPalabra.Name = "rtPalabra";
            this.rtPalabra.Size = new System.Drawing.Size(141, 46);
            this.rtPalabra.TabIndex = 7;
            this.rtPalabra.Text = "";
            this.rtPalabra.DoubleClick += new System.EventHandler(this.rtPalabra_DoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reconcer Imagen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbCrop
            // 
            this.pbCrop.Location = new System.Drawing.Point(570, 12);
            this.pbCrop.Name = "pbCrop";
            this.pbCrop.Size = new System.Drawing.Size(388, 375);
            this.pbCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrop.TabIndex = 10;
            this.pbCrop.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 390);
            this.Controls.Add(this.pbCrop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtPalabra);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.Text = "Bot2121";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.RichTextBox rtPalabra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbCrop;
    }
}

