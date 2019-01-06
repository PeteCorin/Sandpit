using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp
{
    class BusinessPartner
    {

        static string BPID; // the reaon I put this here was an attempt to guess how to persist variables throughout the class

        public String CreateBusinessPartner(string FirstName, string LastName)
        {
            Console.WriteLine($"We have created an ID for {FirstName} {LastName}");
            // Private Static String BusinessPartnerID; // Another attempt to make a variable that is available
            String BusinessPartnerID = FirstName + LastName + "OliviaWantedSomethingDifferent";
            Console.WriteLine($"This is the ID: {BusinessPartnerID}");
            return BusinessPartnerID;

        }

        public static void UpdateBusinessPartner()
        {
            Console.WriteLine($"The current BP ID is: {BPID} what would you like to change it to?");
            BPID = Console.ReadLine();
            Console.WriteLine($"The BP ID is now: {BPID}");
            //return BusinessPartnerID;
        }


        static void Main(string[] args)
        {
            // menu GUI
            // loop while the user hasn't selected x

            string SelectedOption;
     
            do
            {
                Console.WriteLine("Welcome to Pete's Core Banking Demo. What would you like to do?");
                Console.WriteLine("1 - Create BP | 2 - Create Account | 3 - Create Payment");
                Console.WriteLine("4 - Update BP | 5 - Update Account | 6 - Update Payment");
                Console.WriteLine("X - exit");

                // get the users input

                SelectedOption = Console.ReadLine();

                // switch statement to respond to menu selections

                switch (SelectedOption)
                {
                    case "1":
                        Console.WriteLine("What is the firstname?"); // ask for the firstname
                        string FirstName = Console.ReadLine(); // read the users input for the first line
                        Console.WriteLine("What is the last name?"); // ask for the lastname
                        string LastName = Console.ReadLine(); // read the input for the last name

                        // we created a class to represent an object of business partner,
                        // so here we're creating a new object of type business partner, called newBP
                        // then we're creating a string and saying "take the object I just created and call the method on it

                        BusinessPartner newBP = new BusinessPartner();
                        BPID = newBP.CreateBusinessPartner(FirstName, LastName);
                        // public static string BPNumber() {  }
                        break;

                    case "x": // exit
                        Console.WriteLine("Thanks for working with Pete's Core Banking Demo, have a nice day!");
                        break;
                    case "4": // update business partner ID
                              // I'm struggling to figure out how to get the BPID to persist in memory and then retain it for this function if it exists

                        UpdateBusinessPartner();

                        //Console.WriteLine($"If we still have the BP ID available, it is: {BPID}");

                        break;
                    default:
                        Console.WriteLine("You've selected an option that either doesn't exist or I haven't coded for yet. Please select something else");
                        Console.WriteLine("--- x ---");
                        break;
                }

            } while (SelectedOption != "x");


        }
        
    }
}
