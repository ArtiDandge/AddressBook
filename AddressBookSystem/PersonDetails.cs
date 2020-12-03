
namespace AddressBookSystem
{
    public class PersonDetails
    {
        private string first_name;
        private string last_name;
        private string address;
        private string city;
        private string state;
        private int zip;
        private long phone_number;
        private string email;

        public PersonDetails(string first_name, string last_name, string address, string city, string state, int zip, long phone_number, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone_number = phone_number;
            this.email = email;
        }

        public PersonDetails(): this("", "", "", "", "", 0, 0, "")
        {
            
        }

        public string toString()
        {

            return "Person Details: \tFirst name:" + this.first_name + " \tLast name:" + this.last_name + " \t Address:" + this.address + " \tCity:" + this.city + " \tState:"
                    + this.state + " \tZip:" + this.zip + " \tPhone Number:" + this.phone_number + " \tEmail:" + this.email;
        }
    }
}
