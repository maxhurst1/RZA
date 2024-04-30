using RZA.memory;
using RZA.models;
using RZA.settings;

namespace RZA.forms
{
    /*
     * This form is to allow the user to select the date they want to book a ticket to visit the zoo
     * where they will be then redirected to a payment form
     */
    internal partial class TicketForm : Form
    {
        public TicketForm()
        {
            DateTime now = DateTime.Now; // the date at runtime

            InitializeComponent();

            dateTimePicker.MinDate = now; // sets the minium date the user can book a ticket for is today

            // add the amount of months from the settings of how far in advance a user can book a ticket
            now = now.AddMonths(Settings.MAX_TICKET_BOOK_IN_ADVANCE);

            dateTimePicker.MaxDate = now; // sets that advanced time as the maxium date

            costLabel.Text = Settings.ZOO_TICKET_COST.ToString("C"); // displays the cost of a ticket from the settings

            ThemeManager.Apply(this); // apply the active theme to the form
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            User? user = Memory.Get(Memories.User) as User; // gets the user from memory

            // ensures that the user is logged in before they attempt to make a booking
            if (user == null)
            {
                MessageBox.Show("You must be logged in to book tickets.");

                return;
            }

            // the callback to invoke once the payment is succesful
            Util.EmptyDelegate callback = () =>
            {
                DateOnly date = DateOnly.FromDateTime(dateTimePicker.Value);

                Ticket ticket = new Ticket() // creates a ticket model to be inserted into the database
                {
                    Date = date,
                    Entry = Settings.ZOO_OPEN_TIME,
                    Exit = Settings.ZOO_CLOSE_TIME,
                    UserId = user.Id
                };

                SqlFramework.WriteTicket(ticket); // inserts the ticket into the tickets table

                MessageBox.Show("Your tickets have now been booked");

                Close();
            };

            // this will open a payment form for the user to enter their payment details
            // once they have been accepted and the payment successful the passed callback will be invoked
            // which will store the ticket booking into the database

            PaymentForm form = new PaymentForm(Settings.ZOO_TICKET_COST, callback);

            form.ShowDialog();
        }
    }
}
