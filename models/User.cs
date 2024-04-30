namespace RZA.models
{
    /*
     * The user model is used to respresent the properties of a record in the accounts table
     */
    internal class User
    {
        public int Id;
        public string Forename;
        public string Surname;
        public string Email;
        public string Phonenumber;
        public string Country;
        public string Address;
        public string Gender;
        public string Password;
    }
}
