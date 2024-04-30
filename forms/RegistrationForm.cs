using RZA.memory;
using RZA.models;

namespace RZA.forms
{
    /*
     * This form is to handle getting input data required to create a user
     * it will then handle the logic required to have it inserted into the accounts table using SqlFramework
     */
    internal partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            ThemeManager.Apply(this);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // gets the user input from the input boxes from the form
            string forename = forenameField.Text;
            string surname = surnameField.Text;
            string email = emailField.Text;
            string phonenumber = phonenumberField.Text;
            string country = countryBox.Text;
            string address = addressField.Text;
            string gender = genderBox.Text;
            string password = passwordField.Text;

            User user = new User // creates an instance of a user model with the user input data
            {
                Forename = forename,
                Surname = surname,
                Email = email,
                Phonenumber = phonenumber,
                Country = country,
                Address = address,
                Gender = gender,
                Password = password,
            };

            string? property = Util.Integrity(user); // validates the integrity of the user model

            // informs the user the data they must enter to proceed with the registration process and breaks here
            if (property != null)
            {
                MessageBox.Show($"You must fill in your {property}.");

                return;
            }

            // ensures that the password is atleast a length of 8 characters to enhance to password security
            else if (user.Password.Length < 8)
            {
                MessageBox.Show("Password must be atleast 8 characters");

                return;
            }

            // checks if the user has checked the TOS checkbox before writing their account to the database
            else if (!tosCheckBox.Checked)
            {
                MessageBox.Show("You must agree to the TOS before your account can be registered.");

                return;
            }

            // checks if this email already exists on another account
            else if (SqlFramework.EmailExists(user.Email))
            {
                MessageBox.Show("An account with this email already exists.");

                return;
            }

            SqlFramework.WriteUser(user); // wrties the user to the sql accounts table

            // assigns user to memory which will emit the on changed event resulting the ui updating
            // this will result in the user being immidately logged in
            Memory.Set(Memories.User, user);

            MessageBox.Show("Your account has successfully been registered into our systems.");

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // closes the focused form when button is clicked
            Close();
        }
    }
}
