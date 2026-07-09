using System.Security.Cryptography;

namespace practical_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter valid username !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter valid password !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            database d1 = new database(txtUsername.Text, txtPassword.Text);

            string result = d1.FetchResult();

            // Create label dynamically
            Label lblMessage = new Label();
            lblMessage.Name = "lblMessage";
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Size = new Size(320, 25);
            lblMessage.Location = new Point(300, 340);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            if (result == "true")
            {
                lblMessage.Text = "Login Successfully !";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = " Please Enter valid username password !";
                lblMessage.ForeColor = Color.Red;
                txtUsername.Focus();
            }

            this.Controls.Add(lblMessage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
