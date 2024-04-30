namespace RZA.settings
{
    /*
     * Stores static settings that can be accessed anywhere and easily modified
     */
    internal class Settings
    {
        public static TimeOnly ZOO_OPEN_TIME = new TimeOnly(9, 00);
        public static TimeOnly ZOO_CLOSE_TIME = new TimeOnly(20, 00);
        public static int MAX_HOTEL_BOOK_IN_ADVANCE = 12; // 12 months (1 year)
        public static int MAX_TICKET_BOOK_IN_ADVANCE = 12; // 12 months (1 year)
        public static double ZOO_TICKET_COST = 14.99f;
    }
}
