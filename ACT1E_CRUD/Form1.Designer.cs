﻿namespace ACT1E_CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chbShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            LinkSignUp = new LinkLabel();
            label4 = new Label();
            btnSignIn = new Button();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.ForeColor = Color.DimGray;
            chbShowPassword.Location = new Point(37, 302);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 52;
            chbShowPassword.Text = "Show password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(109, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 70);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(37, 431);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(226, 35);
            btnClose.TabIndex = 50;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkSignUp.ForeColor = SystemColors.HotTrack;
            LinkSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkSignUp.LinkColor = SystemColors.HotTrack;
            LinkSignUp.Location = new Point(204, 382);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(67, 20);
            LinkSignUp.TabIndex = 49;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            LinkSignUp.LinkClicked += LinkSignUp_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(31, 383);
            label4.Name = "label4";
            label4.Size = new Size(175, 19);
            label4.TabIndex = 48;
            label4.Text = "Don't have an account?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.HotTrack;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(36, 327);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(226, 44);
            btnSignIn.TabIndex = 41;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(37, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 47;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(36, 270);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(34, 246);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 46;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(37, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 45;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(36, 194);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(34, 164);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 42;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(80, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 40;
            label1.Text = "Sign In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 498);
            Controls.Add(chbShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbShowPassword;
        private PictureBox pictureBox1;
        private Button btnClose;
        private LinkLabel LinkSignUp;
        private Label label4;
        private Button btnSignIn;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel1;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}
