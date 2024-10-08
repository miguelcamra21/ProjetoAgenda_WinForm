namespace ProjetoAgenda_WinForm
{
    partial class Frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_login = new Label();
            textBox_user = new TextBox();
            lbl_user = new Label();
            lbl_password = new Label();
            textBox_password = new TextBox();
            btn_enter = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.BackColor = Color.Transparent;
            lbl_login.Font = new Font("Swis721 BlkEx BT", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.White;
            lbl_login.Location = new Point(167, 9);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(124, 35);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            // 
            // textBox_user
            // 
            textBox_user.Location = new Point(12, 91);
            textBox_user.Name = "textBox_user";
            textBox_user.Size = new Size(194, 23);
            textBox_user.TabIndex = 1;
            textBox_user.TextChanged += textBox_user_TextChanged;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.BackColor = Color.Transparent;
            lbl_user.Font = new Font("Swis721 BlkEx BT", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_user.ForeColor = Color.White;
            lbl_user.Location = new Point(12, 59);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(144, 29);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "Usuário";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Font = new Font("Swis721 BlkEx BT", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(12, 163);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(118, 29);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Senha";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(12, 195);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(194, 23);
            textBox_password.TabIndex = 3;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // btn_enter
            // 
            btn_enter.Enabled = false;
            btn_enter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_enter.Location = new Point(108, 266);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(132, 53);
            btn_enter.TabIndex = 5;
            btn_enter.Text = "Entrar";
            btn_enter.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(246, 266);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(132, 53);
            btn_register.TabIndex = 6;
            btn_register.Text = "Registrar-se";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.corinthians;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 331);
            Controls.Add(btn_register);
            Controls.Add(btn_enter);
            Controls.Add(lbl_password);
            Controls.Add(textBox_password);
            Controls.Add(lbl_user);
            Controls.Add(textBox_user);
            Controls.Add(lbl_login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Frm_login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private TextBox textBox_user;
        private Label lbl_user;
        private Label lbl_password;
        private TextBox textBox_password;
        private Button btn_enter;
        private Button btn_register;
    }
}
