using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System !");
            PersonDetails person = new PersonDetails();
            LinkedList<PersonDetails> contact = new LinkedList<PersonDetails>();
            try
            {
                Console.WriteLine("Address Book Menu");
                Console.WriteLine("1. Add New Person address");
                Console.WriteLine("2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("First name");
                        person.setFirst_name(Console.ReadLine());
                        Console.WriteLine("Last Name");
                        person.setLast_name(Console.ReadLine());
                        Console.WriteLine("Address");
                        person.setAddress(Console.ReadLine());
                        Console.WriteLine("City");
                        person.setCity(Console.ReadLine());
                        Console.WriteLine("State");
                        person.setState(Console.ReadLine());
                        Console.WriteLine("Zip");
                        person.setZip(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("PhoneNo");
                        person.setPhone_number(Convert.ToInt64(Console.ReadLine()));
                        Console.WriteLine("Email");
                        person.setEmail(Console.ReadLine());
                        contact.AddFirst(new PersonDetails(person.getFirst_name(), person.getLast_name(), person.getAddress(), person.getCity(),
                                                           person.getState(), person.getZip(), person.getPhone_number(), person.getEmail()));
                        Console.WriteLine(person.toString());
                        Console.WriteLine("New address added to the book successfully !");
                        break;
                    case 2:
                        Console.WriteLine("You have selected option to exit ..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice ");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Name, address, ciry, state, and email must be string and zip and phone number must be integer only.");
            }
        }
    }
}
