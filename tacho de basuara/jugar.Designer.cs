
namespace tacho_de_basuara
{
     public partial class jugar
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
        public void InitializeComponent()
        {
            this.btsalir1 = new System.Windows.Forms.Button();
            this.btchocar = new System.Windows.Forms.Button();
            this.imgauto1 = new System.Windows.Forms.PictureBox();
            this.imgauto2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgauto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgauto2)).BeginInit();
            this.SuspendLayout();
            // 
            // btsalir1
            // 
            this.btsalir1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsalir1.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir1.ForeColor = System.Drawing.Color.Red;
            this.btsalir1.Location = new System.Drawing.Point(466, 315);
            this.btsalir1.Name = "btsalir1";
            this.btsalir1.Size = new System.Drawing.Size(113, 65);
            this.btsalir1.TabIndex = 0;
            this.btsalir1.Text = "SALIR";
            this.btsalir1.UseVisualStyleBackColor = false;
            this.btsalir1.Click += new System.EventHandler(this.btsalir1_Click);
            // 
            // btchocar
            // 
            this.btchocar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btchocar.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchocar.ForeColor = System.Drawing.Color.Red;
            this.btchocar.Location = new System.Drawing.Point(283, 315);
            this.btchocar.Name = "btchocar";
            this.btchocar.Size = new System.Drawing.Size(93, 65);
            this.btchocar.TabIndex = 1;
            this.btchocar.Text = "CHOCAR";
            this.btchocar.UseVisualStyleBackColor = false;
            this.btchocar.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgauto1
            // 
            this.imgauto1.Image = global::tacho_de_basuara.Properties.Resources.auto1;
            this.imgauto1.Location = new System.Drawing.Point(26, 51);
            this.imgauto1.Name = "imgauto1";
            this.imgauto1.Size = new System.Drawing.Size(196, 129);
            this.imgauto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgauto1.TabIndex = 4;
            this.imgauto1.TabStop = false;
            // 
            // imgauto2
            // 
            this.imgauto2.Image = global::tacho_de_basuara.Properties.Resources.auto2;
            this.imgauto2.Location = new System.Drawing.Point(602, 51);
            this.imgauto2.Name = "imgauto2";
            this.imgauto2.Size = new System.Drawing.Size(168, 85);
            this.imgauto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgauto2.TabIndex = 5;
            this.imgauto2.TabStop = false;
            // 
            // jugar
            // 
            this.ClientSize = new System.Drawing.Size(829, 439);
            this.Controls.Add(this.imgauto2);
            this.Controls.Add(this.imgauto1);
            this.Controls.Add(this.btchocar);
            this.Controls.Add(this.btsalir1);
            this.Name = "jugar";
            ((System.ComponentModel.ISupportInitialize)(this.imgauto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgauto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgpapel;
        private System.Windows.Forms.PictureBox imgtacho;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button btsalir1;
        private System.Windows.Forms.Button btchocar;
        private System.Windows.Forms.PictureBox imgauto1;
        private System.Windows.Forms.PictureBox imgauto2;
    }
}