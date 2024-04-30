using RZA.structures;

namespace RZA.themes
{
    /*
     * The systems dark mode color values
     */
    internal class DarkMode : Theme
    {
        public override Color text { get => Color.DarkKhaki; }
        public override Color textbox { get => Color.White; }
        public override Color label { get => Color.Gray; }
        public override Color button { get => Color.DarkGreen; }
        public override Color datetimepicker { get => Color.White; }
        public override Color combobox { get => Color.White; }
        public override Color form { get => Color.Gray; }
    }
}
