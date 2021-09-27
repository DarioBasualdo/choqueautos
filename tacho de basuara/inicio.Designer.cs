
namespace tacho_de_basuara
{
    partial class inicio
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
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Black;
            this.bt1.Font = new System.Drawing.Font("Old English Text MT", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt1.Location = new System.Drawing.Point(12, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(251, 198);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "inicio";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // inicio
            // 
            this.ClientSize = new System.Drawing.Size(275, 213);
            this.Controls.Add(this.bt1);
            this.Name = "inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btinicio;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button bt1;
    }
}

