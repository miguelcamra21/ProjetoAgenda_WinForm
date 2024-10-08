namespace ProjetoAgenda_WinForm
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void HabilitarButtonEnter()
        {
            if (textBox_user.Text != "" && textBox_password.Text.Length >= 8)
            {
                btn_enter.Enabled = true;
            }
            else
            {
                btn_enter.Enabled = false;
            }
        }
    

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Cadastro frm_Cadastro = new Frm_Cadastro();
            frm_Cadastro.ShowDialog();

        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {
             HabilitarButtonEnter();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            HabilitarButtonEnter();
        }

        private void Frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
