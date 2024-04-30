using RZA.forms;
using RZA.memory;
using RZA.models;

namespace RZA.components
{
    internal partial class Navbar : Form
    {
        /*
         * This form is to provide a navigation bar which is all this form will contain
         * this is to keep code for the navbar seperate to other forms
         * but always always other forms to inherit from navbar to put the navbar on that form
         */
        public Navbar()
        {
            InitializeComponent();

            // assigns a memory changed method to be emitted on change
            // this is responsible for updating the ui of the navbar when the memory changes
            Memory.OnMemoryChanged += OnMemoryChanged;

            ThemeManager.Apply(this);
        }

        private void OnMemoryChanged()
        {
            // retrieves the user from the memory
            User? user = Memory.Get(Memories.User) as User;

            // if the user does exist in memory
            if (user != null)
            {
                loginBtn.Visible = false; // hide the login and register buttons
                registerBtn.Visible = false;

                profileIcon.Visible = true; // shows the icon for accessing the user profile

                return;
            }

            // if the user was cleared from the memory.
            // re-enable the login, register buttons and hide the user's profile
            loginBtn.Visible = true;
            registerBtn.Visible = true;

            profileIcon.Visible = false;
            profileGroupBox.Visible = false;
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            // remove the user from the memory if they sign out
            Memory.Remove(Memories.User);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // when the user clicks on their profile icon simply toggle to bool for visibility
            profileGroupBox.Visible = !profileGroupBox.Visible;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // opens a new instance of a login form when the button clicked
            new LoginForm().ShowDialog();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // opens a new instance of a registration form when the button clicked
            new RegistrationForm().ShowDialog();
        }

        private void hotelBtn_Click(object sender, EventArgs e)
        {
            // opens a new instance of a hotel form when the button clicked
            new HotelForm().ShowDialog();
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            // opens a new instance of a ticket form when the button clicked
            new TicketForm().ShowDialog();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            // this is where the dashboard form will open once it has been implemeneted
            MessageBox.Show("This feature has not yet been implemented.");
        }

        private void educationalVisits_Click(object sender, EventArgs e)
        {
            // this is where the education visits form will open once it has been implemented
            MessageBox.Show("This feature has not yet been implemented.");
        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (ThemeManager.IsTheme(ThemeAtlas.Light)) // checks if the currently active theme is light mode
            {
                ThemeManager.Set(ThemeAtlas.Dark, this); // if so toggle the theme to dark mode
                themeBtn.Text = "☀";
            }
            else
            {
                ThemeManager.Set(ThemeAtlas.Light, this); // otherwise toggle to light 
                themeBtn.Text = "🌙";
            }
        }
    }
}
