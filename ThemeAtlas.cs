using RZA.structures;
using RZA.themes;

namespace RZA
{
    /*
     * stores an instance of all themes as a static variable
     */
    internal static class ThemeAtlas
    {
        public static Theme Dark = new DarkMode();
        public static Theme Light = new LightMode();
    }
}
