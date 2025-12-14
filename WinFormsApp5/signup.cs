namespace RollandKnow
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            string newUser = textBoxname.Text;
            string newPass = textBoxpassword.Text;


            if (string.IsNullOrWhiteSpace(newUser) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Please enter a valid username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool exists = UserDatabase.Users.Any(u => u.username.Equals(newUser, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                MessageBox.Show("This username is alrady registered!", "Register error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            User kullanici = new User { username = newUser, password = newPass };



            UserDatabase.AddUser(kullanici);

            MessageBox.Show("Register has been successful!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}