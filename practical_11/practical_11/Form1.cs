namespace practical_11
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mail = txtEmail.Text;

            string validate = "@gmail.com";

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else if (txtLastname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastname.Focus();
                return;
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (!mail.EndsWith(validate))
            {
                MessageBox.Show("Please enter your valid Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else
            {
                lblMsg.Text = $"Welcome {txtName.Text} {txtLastname.Text}\n{txtEmail.Text}";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
