using RZA.memory;
using RZA.models;
using RZA.settings;

namespace RZA.forms
{
    /*
     * This forms purpose is for the user to be directed to once they have chose
     * which room they want book where they can chose their check in and check out dates
     */
    internal partial class BookingForm : Form
    {
        private Room room;

        public BookingForm(Room _room, Image image)
        {
            DateTime now = DateTime.Now; // the date at runtime

            room = _room;

            InitializeComponent();

            checkInDate.MinDate = now; // set the minium date the user can book a hotel room is today
            checkOutDate.MinDate = now;

            // sets the default value of the check out date to one day later since a booking must be overnight
            checkOutDate.Value = now.AddDays(1);

            // add the amount of months from the settings of how far in advance a user can book a hotel room
            now = now.AddMonths(Settings.MAX_HOTEL_BOOK_IN_ADVANCE);

            checkInDate.MaxDate = now; // set the maxium date the user can book a hotel room based of the settings
            checkOutDate.MaxDate = now;

            pictureBox.Image = image; // shows the room image on the picture box from this form

            ThemeManager.Apply(this); // apply the active theme to the form
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkIn = checkInDate.Value; // get the user inputted data from date time pickers
            DateTime checkOut = checkOutDate.Value;

            // check if the check out time is before or on the same date as the check in date
            if (Util.OverlappingDates(checkIn, checkOut))
            {
                costLabel.Text = "Error: Check in date is after check out"; // if so show an error to the user

                return;
            }

            double nights = (checkOut - checkIn).TotalDays; // the total days that the user will be booking the hotel
            costLabel.Text = (nights * room.price).ToString("C"); // calculates and forms the cost to be displayed to the user
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            // will always be type User since this form cannot be opened unless logged in
            User user = Memory.Get(Memories.User) as User;

            DateOnly checkIn = DateOnly.FromDateTime(checkInDate.Value); // converts the user inputted data to DateOnly
            DateOnly checkOut = DateOnly.FromDateTime(checkOutDate.Value);

            // checks if the dates overlap once again before going to the payment page
            if (Util.OverlappingDates(checkIn.ToDateTime(TimeOnly.MinValue), checkOut.ToDateTime(TimeOnly.MinValue)))
            {
                MessageBox.Show("Error: Check in date is after check out");

                return;
            }

            // creates a callback to be invoked upon a successful payment
            Util.EmptyDelegate callback = () =>
            {
                Booking booking = new Booking() // creates an instance of a booking model
                {
                    RoomNumber = room.number,
                    CheckIn = checkIn,
                    CheckOut = checkOut,
                    UserId = user.Id
                };

                SqlFramework.WriteBooking(booking); // uses the SqlFramework to insert that model into the bookings table

                MessageBox.Show("Your hotel booking has been successful.");

                Close();
            };

            double price = (checkOut.DayNumber - checkIn.DayNumber) * room.price; // works out the price for the booking

            new PaymentForm(price, callback).ShowDialog(); // directs the user to the payment form passing the cost and callback as parameters
        }
    }
}
