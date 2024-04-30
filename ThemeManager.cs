using RZA.structures;

namespace RZA
{
    /*
     * The theme manager is responsible for applying themes to forms
     */
    internal class ThemeManager
    {
        private static Theme theme = ThemeAtlas.Light; // the currently active theme (and default)

        // sets the theme and apply it to the passed control form
        public static void Set(Theme _theme, Control control)
        {
            theme = _theme;

            Apply(control);
        }

        // checks if the passed theme is the currently active theme
        public static bool IsTheme(Theme _theme)
        {
            return _theme == theme;
        }

        // applie the currently active theme to the given control
        public static void Apply(Control _control)
        {
            // gets an array of every subcontrol in the passed control
            // since Form inherits from Control this essentially gets all controls from a form
            Control[] controls = _control.Controls.OfType<Control>().ToArray();

            foreach (Control control in controls) // iterates over each control and check its type to apply the correct color
            {
                if (Util.IsType<TextBox>(control)) 
                    control.BackColor = theme.textbox;
                else if (Util.IsType<ComboBox>(control)) 
                    control.BackColor = theme.combobox;
                else if (Util.IsType<Label>(control)) 
                    control.BackColor = theme.label;
                else if (Util.IsType<Button>(control))
                    control.BackColor = theme.button;
                else if (Util.IsType<DateTimePicker>(control))
                    control.BackColor = theme.datetimepicker;

                control.ForeColor = theme.text; // changes the text color of all controls
            }

            // changes the background color of the main control
            _control.BackColor = theme.form;
        }
    }
}
