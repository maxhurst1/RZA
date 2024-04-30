using RZA.components;

namespace RZA.forms
{
    /*
     * This form is the main page which will be first shown when the program is first opened
     */
    internal partial class HomeForm : Navbar
    {
        public HomeForm()
        {
            InitializeComponent();

            ThemeManager.Apply(this); // apply the active theme to the form
        }
    }
}
