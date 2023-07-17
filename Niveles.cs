using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void Niveles_Load(object sender, EventArgs e)
        {

        }

        private void nivel1_Click(object sender, EventArgs e)
        {
            PrimerNivel nivel1 = new PrimerNivel();
            nivel1.Show();
            this.Hide();
        }

        private void nivel2_Click(object sender, EventArgs e)
        {

        }
    }
}
