using RZA.controls;
using RZA.memory;
using RZA.models;

namespace RZA.forms
{
    /*
     * This form is to show all rooms the hotel has to offer dynamically
     * from the rooms.json file
     */
    internal partial class HotelForm : Form
    {
        private string path = Path.Combine(Util.GetRootDirectory(), "rooms.json"); // the absolute filepath to the rooms.json file

        public HotelForm()
        {
            List<Room> rooms = JsonReader.Read<List<Room>>(path); // uses the JsonReader to create a list of room models

            InitializeComponent();

            /*
             * the following codes handles loading the room data from the rooms.json file
             * then follows a process to create a hotel container for each room to have them displayed in the form
             */

            foreach (Room room in rooms)
            {
                // uses the rooms image to load an image from the images directory
                string image = Path.Combine(Util.GetRootDirectory(), "images", "rooms", room.image);

                // creates a hotel container and assigns the values from the room model to it
                HotelContainer container = new HotelContainer(room)
                {
                    Image = new Bitmap(image) // creates a bitmap image to be shown on the form
                };

                ThemeManager.Apply(container); // apply the active theme to the form

                // adds an event handler to the book room button on the hotel container to invoke the bookBtn_Click method when clicked
                container.BookButtonOnClick += new EventHandler(bookBtn_Click);
                flowLayoutPanel.Controls.Add(container); // adds the hotel container to the flowlayoutpanel to displayed them in a list
            }

            ThemeManager.Apply(this); // apply the active theme to the form
        }

        // event which is ran when the booking button is clicked on the hotel container
        private void bookBtn_Click(object sender, EventArgs e)
        {
            // uses the systems memory to check if a user is logged in as this is required to book a hotel room
            User? user = Memory.Get(Memories.User) as User;

            if (user == null)
            {
                MessageBox.Show("You must be logged in to book a room.");

                return;
            }

            // if they are logged in they can be directed to a booking form to comtinue the process
            HotelContainer container = (HotelContainer)sender;

            new BookingForm(container.room, container.Image).ShowDialog();
        }
    }
}
