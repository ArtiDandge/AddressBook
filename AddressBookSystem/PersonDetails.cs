
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

        public string getFirst_name()
        {
            return first_name;
        }

        public void setFirst_name(string first_name)
        {
            this.first_name = first_name;
        }

        public string getLast_name()
        {
            return last_name;
        }

        public void setLast_name(string last_name)
        {
            this.last_name = last_name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getCity()
        {
            return city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getState()
        {
            return state;
        }

        public void setState(string state)
        {
            this.state = state;
        }

        public int getZip()
        {
            return zip;
        }

        public void setZip(int zip)
        {
            this.zip = zip;
        }

        public long getPhone_number()
        {
            return phone_number;
        }

        public void setPhone_number(long phone_number)
        {
            this.phone_number = phone_number;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string toString()
        {

            return "Person Details: \tFirst name:" + this.first_name + " \tLast name:" + this.last_name + " \t Address:" + this.address + " \tCity:" + this.city + " \tState:"
                    + this.state + " \tZip:" + this.zip + " \tPhone Number:" + this.phone_number + " \tEmail:" + this.email;
        }
    }
}
