using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            Console.Write("First name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
