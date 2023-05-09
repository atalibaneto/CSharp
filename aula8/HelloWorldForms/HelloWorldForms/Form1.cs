namespace HelloWorldForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmMensagem mensagem = new frmMensagem();
            mensagem.Show();
        }
    }
}