using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the questions below.");
            Console.WriteLine("Press Enter:");
            Console.ReadLine();
            Console.WriteLine("Please enter package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight >= 50) 
            {
               Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
               Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("What is the package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

              
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big tp be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int totalDimensions = packageWidth + packageHeight + packageLength;
                    int totalQuote = (totalDimensions * packageWeight);
                    string quote = (totalQuote / 100m).ToString("C2");

                    Console.WriteLine("Your quoted amount is: " + quote);
                    Console.ReadLine();




                }
            }
        }
    }
    
}
