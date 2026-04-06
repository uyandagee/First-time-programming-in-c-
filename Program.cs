using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Enterence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to enter their age
            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();

            // covert the input to an integer
            int age;
            if (int.TryParse(input, out age) )
            {
                // cheak for the users age
                if (age >= 21)
                {
                    Console.WriteLine("Congrats ufukile emabhozeni");
                }
                else
                {
                    Console.WriteLine("Awulenzi ixesha boiii");
                }
            }
            else
            { 
                Console.WriteLine("Invalid selsection. Please enter a number."); 
            }
            // keep the console window open
            Console.WriteLine(" press any key to exit...!");
            Console.ReadKey();
            {

            }
        }
    }
}
