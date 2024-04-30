namespace RZA.models
{
    /*
     * The booking model is used to respresent the properties of a record in the bookings table
     */
    internal class Booking
    {
        public int Id;
        public string RoomNumber;
        public DateOnly CheckIn;
        public DateOnly CheckOut;
        public int UserId;
    }
}
