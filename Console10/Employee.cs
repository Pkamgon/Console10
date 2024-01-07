using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    // Define a class named Employee that implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Declare a property named FirstName of type string
        public string FirstName { get; set; }
        // Declare a property named LastName of type string
        public string LastName { get; set; }

        // Define a constructor for the Employee class that takes two parameters
        public Employee(string firstName, string lastName)
        {
            // Assign the firstName parameter to the FirstName property
            FirstName = firstName;
            // Assign the lastName parameter to the LastName property
            LastName = lastName;
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Write a message to the console
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}

