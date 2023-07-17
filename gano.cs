using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class gano : Form
    {
        public gano()
        {
            InitializeComponent();
        }

        private void picSi_Click(object sender, EventArgs e)
        {
            SegundoNivel nivel2 = new SegundoNivel();
            nivel2.Show();
            this.Hide();
        }

        private void picNo_Click(object sender, EventArgs e)
        {
            Niveles regreso = new Niveles();
            regreso.Show();
            this.Hide();
        }

        private void picGano_Click(object sender, EventArgs e)
        {
            mensajerobot iramensaje = new mensajerobot();
            iramensaje.Show();
            this.Hide();
        }
    }
}
