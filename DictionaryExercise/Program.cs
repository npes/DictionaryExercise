/*
    Written by Nikolaj Simonsen 28.09.2017
    The program makes a dictionary and adds 3 entries to it.
    The user is prompted to enter a person and the program responds 
    with the persons phonenumber if it exists. 
    The searchterm is not case sensitive.
*/

using System;
using System.Collections.Generic;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>(); //instantiate a Dictionary called phoneBook

            //Add entries in phoneBook
            phoneBook.Add("Nikolaj", 004512345698);
            phoneBook.Add("Kurt", 003387654562);
            phoneBook.Add("Joan", 0047123456543);

            Console.WriteLine("Who are you searching for: ");
            string searchTerm = Console.ReadLine(); //user input 
            string result = "The phonenumber is not in the phonebook"; //holds search result or default string

            foreach (KeyValuePair<string, long> item in phoneBook)
            {
                if (searchTerm.ToLower() == item.Key.ToLower())
                {
                    result = (item.Key + "'s phone number is " + item.Value);
                }
                else
                {
                    //nothing
                }
            }

            Console.WriteLine(result);
            Console.ReadLine(); //keep the console open
        }
    }
}
