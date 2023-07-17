namespace Ahorcados
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Niveles irnivel = new Niveles();
            irnivel.Show();
            this.Hide();
        }
    }
}