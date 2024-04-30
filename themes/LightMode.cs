using RZA.structures;

namespace RZA.themes
{
    /*
     * The systems light mode color values
     */
    internal class LightMode : Theme
    {
        public override Color text { get => Color.Black; }
        public override Color textbox { get => Color.White; }
        public override Color label { get => Color.LightGray; }
        public override Color button { get => Color.LimeGreen; }
        public override Color datetimepicker { get => Color.White; }
        public override Color combobox { get => Color.White; }
        public override Color form { get => Color.LightGray; }
    }
}
