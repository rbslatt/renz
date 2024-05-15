namespace ACT1E_CRUD
{
    partial class register
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
            label2 = new Label();
            label1 = new Label();
            txtname = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            label4 = new Label();
            txtpassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(80, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 37);
            label2.TabIndex = 41;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(9, 135);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 43;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtname.ForeColor = Color.DimGray;
            txtname.Location = new Point(12, 155);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Enter your name";
            txtname.Size = new Size(226, 25);
            txtname.TabIndex = 44;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 47;
            label3.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.DimGray;
            txtusername.Location = new Point(12, 227);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter your username";
            txtusername.Size = new Size(226, 25);
            txtusername.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(9, 287);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 49;
            label4.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.DimGray;
            txtpassword.Location = new Point(9, 307);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Enter your password";
            txtpassword.Size = new Size(226, 25);
            txtpassword.TabIndex = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 370);
            button1.Name = "button1";
            button1.Size = new Size(226, 44);
            button1.TabIndex = 51;
            button1.Text = "Register Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 441);
            button2.Name = "button2";
            button2.Size = new Size(226, 44);
            button2.TabIndex = 52;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 537);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtname;
        private Label label3;
        private TextBox txtusername;
        private Label label4;
        private TextBox txtpassword;
        private Button button1;
        private Button button2;
    }
}