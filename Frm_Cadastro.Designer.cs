﻿namespace ProjetoAgenda_WinForm
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_cadastro = new Label();
            lbl_name = new Label();
            textBox_name = new TextBox();
            label1 = new Label();
            textBox_user = new TextBox();
            lbl_phone = new Label();
            textBox_phone = new TextBox();
            lbl_password = new Label();
            textBox_password = new TextBox();
            lbl_password2 = new Label();
            textBox_password2 = new TextBox();
            btn_cancel = new Button();
            btn_register2 = new Button();
            SuspendLayout();
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.BackColor = Color.Transparent;
            lbl_cadastro.Font = new Font("Swis721 BlkEx BT", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = Color.White;
            lbl_cadastro.Location = new Point(159, 9);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(188, 35);
            lbl_cadastro.TabIndex = 1;
            lbl_cadastro.Text = "Registro";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Swis721 BlkEx BT", 15.75F, FontStyle.Italic);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(12, 56);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(97, 25);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "Nome";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(12, 84);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(237, 23);
            textBox_name.TabIndex = 3;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 BlkEx BT", 15.75F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 6;
            label1.Text = "Usuário";
            // 
            // textBox_user
            // 
            textBox_user.Location = new Point(12, 146);
            textBox_user.Name = "textBox_user";
            textBox_user.Size = new Size(237, 23);
            textBox_user.TabIndex = 5;
            textBox_user.TextChanged += textBox_user_TextChanged;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.BackColor = Color.Transparent;
            lbl_phone.Font = new Font("Swis721 BlkEx BT", 15.75F, FontStyle.Italic);
            lbl_phone.ForeColor = Color.White;
            lbl_phone.Location = new Point(12, 199);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(137, 25);
            lbl_phone.TabIndex = 8;
            lbl_phone.Text = "Telefone";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(12, 227);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(237, 23);
            textBox_phone.TabIndex = 7;
            textBox_phone.TextChanged += textBox_phone_TextChanged;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Font = new Font("Swis721 BlkEx BT", 15.75F, FontStyle.Italic);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(12, 271);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(106, 25);
            lbl_password.TabIndex = 10;
            lbl_password.Text = "Senha";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(12, 299);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(237, 23);
            textBox_password.TabIndex = 9;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // lbl_password2
            // 
            lbl_password2.AutoSize = true;
            lbl_password2.BackColor = Color.Transparent;
            lbl_password2.Font = new Font("Swis721 BlkEx BT", 15.75F, FontStyle.Italic);
            lbl_password2.ForeColor = Color.White;
            lbl_password2.Location = new Point(12, 334);
            lbl_password2.Name = "lbl_password2";
            lbl_password2.Size = new Size(272, 25);
            lbl_password2.TabIndex = 12;
            lbl_password2.Text = "Repita sua senha";
            // 
            // textBox_password2
            // 
            textBox_password2.Location = new Point(12, 362);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.PasswordChar = '*';
            textBox_password2.Size = new Size(237, 23);
            textBox_password2.TabIndex = 11;
            textBox_password2.TextChanged += textBox_password2_TextChanged;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cancel.Location = new Point(411, 340);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(111, 45);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_register2
            // 
            btn_register2.Enabled = false;
            btn_register2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_register2.Location = new Point(294, 340);
            btn_register2.Name = "btn_register2";
            btn_register2.Size = new Size(111, 45);
            btn_register2.TabIndex = 14;
            btn_register2.Text = "Registar";
            btn_register2.UseVisualStyleBackColor = true;
            // 
            // Frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.corinthians;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 393);
            Controls.Add(btn_register2);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_password2);
            Controls.Add(textBox_password2);
            Controls.Add(lbl_password);
            Controls.Add(textBox_password);
            Controls.Add(lbl_phone);
            Controls.Add(textBox_phone);
            Controls.Add(label1);
            Controls.Add(textBox_user);
            Controls.Add(lbl_name);
            Controls.Add(textBox_name);
            Controls.Add(lbl_cadastro);
            Name = "Frm_Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Cadastro";
            FormClosed += Frm_Cadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cadastro;
        private Label lbl_name;
        private TextBox textBox_name;
        private Label label1;
        private TextBox textBox_user;
        private Label lbl_phone;
        private TextBox textBox_phone;
        private Label lbl_password;
        private TextBox textBox_password;
        private Label lbl_password2;
        private TextBox textBox_password2;
        private Button btn_cancel;
        private Button btn_register2;
    }
}