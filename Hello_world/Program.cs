/*
 *  Teachers notes:
 *     Main() - function must be implemented in all C# programs
 *     Console.WriteLine() is a function we can use to print something to the console
 *     int is a data type used to store numbers
 *     char is a data type used to store characters
 *     string is a data type used to store sequence of characters
 * 
 */

// Namespace declaration this will allow us to user the System namespace
using System;

// Our C# station namespace
namespace Hello_world
{
    // Program start class
    class Program
    {
        // This is a function called Main()
        // all programs in C# must have it
        static void Main()
        {
            // Send "Hello World!" to the Console
            Console.WriteLine("Hello World!");

            // Declare a variable age and assign it a value of 25
            int Age = 25;
            
            Console.WriteLine(Age);
            
            // Declare a character
            char grade = 'A';
            
            // Name is an Array with characters
            char[] name = {'B','Y','A','M','U','N','G','U'};

            // Change the first character in name at index 0
            name[0] = 'C';
            
            // Declare a string
            String Fullname = "Byamungu Kabiraba";
            
            // Print out the fist character at index 0 from fullname
            Console.WriteLine(Fullname[0]);
        }
    }
}