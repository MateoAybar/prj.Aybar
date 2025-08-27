using prj.AybarSP1;

namespace prj.Aybar
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            ventanaInicio.ShowDialog();

        }
    }
}
