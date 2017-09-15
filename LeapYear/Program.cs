using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {

        static void Main(string[] args)
        {
            Test TestGivenNumber = new Test();

            Console.WriteLine("Test for Leap Year. Please enter a year");
            int GivenYear = Convert.ToInt32(Console.ReadLine());

            bool LeapYearStatus = TestGivenNumber.CalculateLeapStatus(GivenYear);

            if (LeapYearStatus == true)
            {
                Console.WriteLine(GivenYear + " is a leap year");
            }
            else
            {
                Console.WriteLine(GivenYear + " is not a leap year");
            }
            Console.ReadKey();
        }
    }
}
