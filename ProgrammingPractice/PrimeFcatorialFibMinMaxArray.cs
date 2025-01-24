using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    public class PrimeFcatorialFibMinMaxArray
    {
        public static void GivenNumisPrime()
        {
            int a = 19,b = 20;
            bool isprime = true;
            for(int i =2; i<=b/2; i++)
            {
                if (b % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime) { Console.WriteLine($"{b} is a Prime"); }
            else { Console.WriteLine($"{b} is not a Prime"); }
        }
        public static void Main(string[] args)
        {
            GivenNumisPrime();
        }
    }
}
