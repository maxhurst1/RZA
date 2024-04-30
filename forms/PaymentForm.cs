using RZA.structures;

namespace RZA.forms
{
    /*
     * This form was designed to be dynamic to work with any order
     * this is done using callbacks
     * the cost of the item and the callback to be invoked is passed as parameters in the constructor
     * this way they can be set in each payment
     * once the user has entered their payment information the payment for that amount can be sent
     * once accepted and approved the callback can be invoked which will run logic for once the payment is accepted
     */
    internal partial class PaymentForm : Form
    {
        private Util.EmptyDelegate callback; // the callback to invoke when the payment is successful

        /*
         * Parameters:
         *     - cost (double) - the amount the user will be paying
         *     - callback (Util.EmptyDelegate) - the callback which will be invoked upon successful payment
         *       used to run logic for that purchase after its been accepted
         */
        public PaymentForm(double cost, Util.EmptyDelegate callback)
        {
            this.callback = callback;

            InitializeComponent();

            costLabel.Text = "You will be charged " + cost.ToString("C");

            ThemeManager.Apply(this); // apply the active theme to the form
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            // gets the user input data from the input boxes
            string csc = cscodeField.Text;
            string cardnumber = cardnumberField.Text;
            string expirydate = expiryField.Text;

            PaymentDetails details = new PaymentDetails() // creates an instance of a payment model using the user data
            {
                card_security_code = csc,
                card_number = cardnumber,
                card_expiry_date = expirydate
            };

            // uses Util methods to validate the integrity of the data ensures that all properties in the model have data
            string? property = Util.Integrity(details);

            if (property != null)
            {
                MessageBox.Show($"You must enter {property} to continue the payment.");

                return;
            }

            /*
             * This is where in the real build the payment would be processed
             * and the flow would only continue if the payment was successful
             */

            // invoke the callback. this is typically used to run logic to save the payment in the system
            callback.Invoke();

            Close();
        }
    }
}
