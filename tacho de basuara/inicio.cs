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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
           // SoundPlayer inicio = new SoundPlayer();
            //inicio.Stream = Properties.Resources.musica_inicio;
            //inicio.Play();

            Form jugar = new jugar();
            jugar.Show();
        }
    }
}
