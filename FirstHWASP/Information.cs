using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHWASP
{
    public class Information
    {
        public static string SetName()
        {
            do
            {
                try
                {
                    Console.WriteLine("Write your name:");

                    string name = Console.ReadLine().Trim();

                    if(name.Any(letter => (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z')))
                    {
                        return name; 
                    }

                    throw new ArgumentException("The name was entered incorrectly");
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (true);
        }

        public static double SetAverageMark()
        {
            do
            {
                Console.WriteLine("Enter an average rating: ");

                string avgMarkString = Console.ReadLine().Trim();
                double avgMark;

                if(double.TryParse(avgMarkString, out avgMark))
                {
                    return avgMark;
                }

                Console.WriteLine("The average rating was entered incorrectly");
            } while (true);
        }
    }
}
