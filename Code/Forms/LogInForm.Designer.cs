﻿

namespace Forms
{
    partial class LoginForm
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
            panel2 = new Panel();
            panel_login = new Panel();
            textBox_login = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel_password = new Panel();
            label2 = new Label();
            textBox_password = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            login_button = new Controls.RoundButton();
            panel_MainLoader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_MainLoader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel_login);
            panel2.Controls.Add(textBox_login);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 72);
            panel2.TabIndex = 0;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.DarkGray;
            panel_login.Location = new Point(8, 61);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(328, 2);
            panel_login.TabIndex = 1;
            // 
            // textBox_login
            // 
            textBox_login.BackColor = Color.FromArgb(20, 30, 49);
            textBox_login.BorderStyle = BorderStyle.None;
            textBox_login.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_login.ForeColor = Color.White;
            textBox_login.Location = new Point(40, 28);
            textBox_login.MaxLength = 50;
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(296, 32);
            textBox_login.TabIndex = 6;
            textBox_login.TextChanged += textBox_login_TextChanged;
            textBox_login.Enter += textBox_login_Enter;
            textBox_login.Leave += textBox_login_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_icon1;
            pictureBox1.Location = new Point(-4, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel_password);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBox_password);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 81);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 73);
            panel4.TabIndex = 7;
            // 
            // panel_password
            // 
            panel_password.BackColor = Color.DarkGray;
            panel_password.Location = new Point(8, 61);
            panel_password.Name = "panel_password";
            panel_password.Size = new Size(328, 2);
            panel_password.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(20, 30, 49);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.White;
            textBox_password.Location = new Point(41, 28);
            textBox_password.MaxLength = 50;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(295, 32);
            textBox_password.TabIndex = 6;
            textBox_password.UseSystemPasswordChar = true;
            textBox_password.TextChanged += textBox_password_TextChanged;
            textBox_password.Enter += textBox_password_Enter;
            textBox_password.Leave += textBox_password_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.key_icon;
            pictureBox2.Location = new Point(6, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = Properties.Resources.Nova_Poshta_2014;
            pictureBox3.Location = new Point(425, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(350, 330);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(3, 121, 244);
            login_button.BackgroundColor = Color.FromArgb(3, 121, 244);
            login_button.BorderColor = Color.White;
            login_button.BorderRadius = 4;
            login_button.BorderSize = 0;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(425, 599);
            login_button.Name = "login_button";
            login_button.Size = new Size(350, 46);
            login_button.TabIndex = 10;
            login_button.Text = "LOG IN";
            login_button.TextColor = Color.White;
            login_button.UseVisualStyleBackColor = false;
            // 
            // panel_MainLoader
            // 
            panel_MainLoader.BackColor = Color.FromArgb(20, 30, 49);
            panel_MainLoader.Controls.Add(tableLayoutPanel1);
            panel_MainLoader.Controls.Add(login_button);
            panel_MainLoader.Controls.Add(pictureBox3);
            panel_MainLoader.Dock = DockStyle.Fill;
            panel_MainLoader.Location = new Point(0, 0);
            panel_MainLoader.Name = "panel_MainLoader";
            panel_MainLoader.Size = new Size(1200, 700);
            panel_MainLoader.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(425, 421);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(350, 157);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1200, 700);
            Controls.Add(panel_MainLoader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_MainLoader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Panel panel_password;
        private Label label2;
        private TextBox textBox_password;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel_login;
        private TextBox textBox_login;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Controls.RoundButton login_button;
        private Panel panel_MainLoader;
        private TableLayoutPanel tableLayoutPanel1;
    }
}