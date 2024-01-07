using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    // Define a class named Program
    class Program
    {
        // Define the Main method which is the entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee("John", "Doe");

            // Use polymorphism to assign the employee instance to an IQuittable reference
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable reference
            quittableEmployee.Quit();

            // Wait for the user to press enter before closing the console window
            Console.ReadLine();
        }
    }
}
