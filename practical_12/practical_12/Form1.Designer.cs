namespace practical_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblInstruction;
        private TextBox txtInput;
        private Button btnLeft;
        private Button btnCenter;
        private Button btnRight;

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
            lblTitle = new Label();
            lblInstruction = new Label();
            txtInput = new TextBox();
            btnLeft = new Button();
            btnCenter = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(250, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Text Alignment Tool";
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 10F);
            lblInstruction.ForeColor = Color.FromArgb(60, 60, 60);
            lblInstruction.Location = new Point(250, 90);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(313, 23);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Enter text below and choose alignment:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F);
            txtInput.Location = new Point(150, 130);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Type your text here...";
            txtInput.Size = new Size(500, 34);
            txtInput.TabIndex = 2;
            txtInput.Text = "Hello Word";
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.White;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLeft.ForeColor = Color.FromArgb(30, 30, 30);
            btnLeft.Location = new Point(200, 200);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(100, 40);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "Left";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnCenter
            // 
            btnCenter.BackColor = Color.White;
            btnCenter.FlatStyle = FlatStyle.Flat;
            btnCenter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCenter.ForeColor = Color.FromArgb(30, 30, 30);
            btnCenter.Location = new Point(350, 200);
            btnCenter.Name = "btnCenter";
            btnCenter.Size = new Size(100, 40);
            btnCenter.TabIndex = 4;
            btnCenter.Text = "Center";
            btnCenter.UseVisualStyleBackColor = false;
            btnCenter.Click += btnCenter_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.White;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRight.ForeColor = Color.FromArgb(30, 30, 30);
            btnRight.Location = new Point(500, 200);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(100, 40);
            btnRight.TabIndex = 5;
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblInstruction);
            Controls.Add(txtInput);
            Controls.Add(btnLeft);
            Controls.Add(btnCenter);
            Controls.Add(btnRight);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Alignment Practical";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
