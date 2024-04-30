namespace RZA.models
{
    /*
     * The ticket model is used to respresent the properties of a record in the tickets table
     */
    internal class Ticket
    {
        public string Id;
        public DateOnly Date;
        public TimeOnly Entry;
        public TimeOnly Exit;
        public int UserId;
    }
}
