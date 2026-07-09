namespace practical_13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 25, 112);
            lblTitle.Location = new Point(280, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔒 User Login";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new Point(250, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(286, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your credentials to continue";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.ForeColor = Color.FromArgb(50, 50, 50);
            lblUsername.Location = new Point(180, 160);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "👤 Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.ForeColor = Color.FromArgb(50, 50, 50);
            lblPassword.Location = new Point(180, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(117, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "🔑 Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(300, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(320, 32);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(300, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(320, 32);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(300, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
