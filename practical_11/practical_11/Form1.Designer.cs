namespace practical_11
{
    partial class frmRegister
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
            lblName = new Label();
            lbllastname = new Label();
            lblEmail = new Label();
            btnExit = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaption;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new Point(186, 126);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 43);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.BackColor = SystemColors.ActiveCaption;
            lbllastname.BorderStyle = BorderStyle.FixedSingle;
            lbllastname.Location = new Point(122, 178);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(183, 43);
            lbllastname.TabIndex = 1;
            lbllastname.Text = "Last Name :";
            lbllastname.Click += label2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ActiveCaption;
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Location = new Point(192, 234);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 43);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(357, 302);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 55);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SpringGreen;
            btnRegister.Location = new Point(186, 302);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 55);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveBorder;
            txtName.Location = new Point(333, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 47);
            txtName.TabIndex = 5;
            // 
            // txtLastname
            // 
            txtLastname.BackColor = SystemColors.ActiveBorder;
            txtLastname.Location = new Point(333, 174);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(239, 47);
            txtLastname.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveBorder;
            txtEmail.Location = new Point(333, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 47);
            txtEmail.TabIndex = 7;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.LimeGreen;
            lblMsg.Location = new Point(131, 372);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 41);
            lblMsg.TabIndex = 8;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(751, 619);
            Controls.Add(lblMsg);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Controls.Add(btnExit);
            Controls.Add(lblEmail);
            Controls.Add(lbllastname);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegister";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lbllastname;
        private Label lblEmail;
        private Button btnExit;
        private Button btnRegister;
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private Label lblMsg;
    }
}
