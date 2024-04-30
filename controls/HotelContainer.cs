using RZA.models;

namespace RZA.controls
{
    /*
     * The hotel view is used to display information on a room in the hotel under a user control
     */
    internal partial class HotelContainer : UserControl
    {
        // event emitted when the button on the hotel container is clicked
        public event EventHandler BookButtonOnClick;

        public Room room;

        // sets the image in the picturebox found in the hotel container designer
        public Image Image
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }

        public HotelContainer(Room _room) // room model as a parameter for the hotel container
        {
            InitializeComponent();

            room = _room;

            // sets the price and description of labels in the designer using the room model data
            descriptionLabel.Text = _room.description;
            priceLabel.Text = _room.price.ToString("C");
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            BookButtonOnClick(this, e); // emits the button on click event and passes itself as the sender in the arguemnts
        }
    }
}
