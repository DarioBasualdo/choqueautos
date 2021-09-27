
namespace tacho_de_basuara
{
    partial class bomba
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
            this.imgbomba = new System.Windows.Forms.PictureBox();
            this.btsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbomba)).BeginInit();
            this.SuspendLayout();
            // 
            // imgbomba
            // 
            this.imgbomba.Image = global::tacho_de_basuara.Properties.Resources.download1;
            this.imgbomba.Location = new System.Drawing.Point(12, 0);
            this.imgbomba.Name = "imgbomba";
            this.imgbomba.Size = new System.Drawing.Size(784, 438);
            this.imgbomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbomba.TabIndex = 3;
            this.imgbomba.TabStop = false;
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.Red;
            this.btsalir.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btsalir.Location = new System.Drawing.Point(700, 400);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(75, 23);
            this.btsalir.TabIndex = 4;
            this.btsalir.Text = "salir";
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // bomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.imgbomba);
            this.Name = "bomba";
            this.Text = "bomba";
            ((System.ComponentModel.ISupportInitialize)(this.imgbomba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgbomba;
        private System.Windows.Forms.Button btsalir;
    }
}