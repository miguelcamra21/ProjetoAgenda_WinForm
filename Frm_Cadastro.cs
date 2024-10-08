using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda_WinForm
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void HabilitarButtonRegister()
        {
            if (textBox_name.Text != "" && textBox_user.Text != "" && textBox_password.Text.Length >= 8 && textBox_password2.Text.Length >= 8 && textBox_password.Text == textBox_password2.Text)
            {
                btn_register2.Enabled = true;
            }
            else
            {
                btn_register2.Enabled = false;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_login frm_Login = new Frm_login();
            frm_Login.ShowDialog();

        }

        private void Frm_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            HabilitarButtonRegister();
        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {
            HabilitarButtonRegister();
        }


        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            HabilitarButtonRegister();
        }

        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {
            HabilitarButtonRegister();
        }

        private void btn_register2_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost;Database=db_agenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            conexao.Open();

            string sql = $"INSERT INTO tb_users (nome, usuario, telefone, senha) VALUES ('{textBox_name.Text}', '{textBox_user.Text}', '{textBox_phone.Text}', '{textBox_password}')";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
