using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace tacho_de_basuara
{
    public partial class jugar : Form
    {
        public jugar()
        {
            InitializeComponent();
        }

        public void jugar_Load(object sender, EventArgs e)
        {
            imgauto1.Top = 80;
            imgauto2.Top = 80;
        }


        private void btsalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SoundPlayer autoacelerando = new SoundPlayer();
            autoacelerando.Stream = Properties.Resources.Auto_Acelerando_wav;
            autoacelerando.Play();

            while (true)
            {
                imgauto1.Left = imgauto1.Left + 1;
                imgauto2.Left = imgauto2.Left - 1;

                this.Refresh();

                if ((imgauto1.Left + imgauto1.Width) == imgauto2.Left)
                {
                    break;

                }



            }
            SoundPlayer bomba2 = new SoundPlayer();
            bomba2.Stream = Properties.Resources.sonido_de_explosión_wav;
            bomba2.Play();
            Form bomba = new bomba();
            bomba.Show();
            this.Close();
        }

    }
}
