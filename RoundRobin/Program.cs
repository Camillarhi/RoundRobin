
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoundRobinBuddyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the buddies for each user
            List<string> buddies = new(){ "buddy1", "buddy2", "buddy3" };
            // Create a list to store the users
            List<string> users = new();


            // Create a variable to keep track of the current index in the list of users
            int currentIndex = 0;//get last user id

            // Continuously read input from the console
            while (true)
            {
                Console.WriteLine("Enter a user name (or press 'q' to quit):");
                string input = Console.ReadLine();

                // If the user entered 'q', exit the loop
                if (input == "q")
                {
                    break;
                }

                // Add the new user to the list of users
                users.Add(input);

                // Assign a buddy to the new user using the round-robin algorithm
                if (buddies.Any())
                {
                    var b = buddies.First();
                   // buddies.Add(buddies[currentIndex]);//add the first to the end
                    Console.WriteLine($"{input} has been assigned {b} as a buddy.");
                    buddies.Remove(b);
                    buddies.Add(b);
                    foreach (var item in buddies)
                    {
                        Console.WriteLine(item);
                    }

                }
                else
                {
                    buddies.Add("None");
                    Console.WriteLine($"{input} has been assigned no buddy.");
                }

                // Increment the current index and wrap around if necessary
                currentIndex++;
            }

            // Print the final list of users and their assigned buddies
            Console.WriteLine("Final list of users and buddies:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{users[i]}: {buddies[i]}");
            }
        }
    }
}


