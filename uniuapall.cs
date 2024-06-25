namespace uniuapall
{
    public partial class uniuapall : Form
    {
        public uniuapall()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistrarCarrera frmRegistrar = new();
            frmRegistrar.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            login.Enabled = false;
            LoginUsuario frmLogin = new();
            frmLogin.Show();
        }
    }
}
