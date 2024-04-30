namespace RZA.structures
{
    /*
     * The base class for a theme where the values will be overriden to build a theme
     */
    internal class Theme
    {
        public virtual Color text { get; }
        public virtual Color combobox { get; }
        public virtual Color textbox { get; }
        public virtual Color label { get; }
        public virtual Color button { get; }
        public virtual Color datetimepicker { get; }
        public virtual Color form { get; }
    }
}
