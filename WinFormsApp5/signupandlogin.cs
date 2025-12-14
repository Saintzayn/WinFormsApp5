namespace RollandKnow
{
    public partial class signupandlogin : Form
    {
        public signupandlogin()
        {

            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string user = textBoxname1.Text;
            string pass = textBoxpassword1.Text;


            var found = UserDatabase.Users
                .FirstOrDefault(u => u.username == user && u.password == pass);

            if (found != null)
            {
                MessageBox.Show("Login succesfull!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Anamenü ana = new Anamenü(found);
                ana.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsignup1_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.ShowDialog();

        }


    }
}