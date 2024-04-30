using RZA.memory;
using RZA.models;

namespace RZA.forms
{
    /*
     * This form is to provide input boxes for the users email and password
     * and handle storing the login data into memory
     */
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            ThemeManager.Apply(this); // apply the active theme to the form
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;

            // ensures that the user has entered both their email and password for the login process
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                // informs the user on their input data and breaks here
                MessageBox.Show("Please enter your email and password to continue.");

                return;
            }

            User? user = SqlFramework.FindUser(email, password);

            // checking if the inputted data was able to match a result in the accounts table
            if (user == null)
            {
                MessageBox.Show("Incorrect login credentials.");

                return;
            }

            // assigning the user to the systems memory
            Memory.Set(Memories.User, user);

            MessageBox.Show($"Welcome, {Util.Capitalise(user.Forename)} to the system.");

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // closes the focused form when button is clicked
            Close();
        }
    }
}
