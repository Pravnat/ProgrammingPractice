using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    public class OddAndEvenPrograme
    {
        public static void FindOddAndEvenInRange()
        {
            for(int i = 1; i < 30; i++) 
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{i} is a Even Number");
                }
            }
            for (int i = 1; i < 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i} is a odd Number");
                }
            }
        }
        public static void FindEvenAndOddinArrray()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12 };
            foreach(int num in arr)
            {
                if(num%2 == 0)
                {
                    Console.WriteLine($"{num} is even Number");
                }
            }
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine($"{num} is odd Number");
                }
            }

        }
        public static void FindEvenAndOddWithoutModulus()
        {
            int a = 44;
            int b = 11;
            if ((a & 1) == 0)
            {
                Console.WriteLine($"{a} is Even Number");
            }
            if((b & 1) == 1) 
            { 
                Console.WriteLine($"{b} is odd Number");
            }
        }

        public static void EvenAndOddiNDifferentArray()
        {
            int[] arr = { 23, 42, 76, 45, 90, 87, 32 };
            List<int> Even = new List<int>();
            List<int> Odd = new List<int>();
            foreach(int num in arr)
            {
                if(num %2 == 0)
                {
                    Even.Add(num);
                }
                else
                {
                    Odd.Add(num);
                }

            }

            int[] EvenArray = Even.ToArray();
            int[] OddArray = Odd.ToArray();

            Console.WriteLine("Even Number: " + String.Join(", ", EvenArray));
            Console.WriteLine("Odd Number: " + String.Join(", ", OddArray));
        }
        public static void SumOfEvenAndOddNumbersInRange()
        {
            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;
            for(int i = 1; i < 30; i++)
            {
                if(i % 2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
                else
                {
                    sumOfOddNumbers += i;
                }

            }
            Console.WriteLine($"Sum of Even Numbers = {sumOfEvenNumbers}");
            Console.WriteLine($"Sum of Odd Numbers = {sumOfOddNumbers}");
        }
        public static void SumOfEvenAndOddNumbersInArray()
        {
            int[] arr = { 23, 42, 76, 45, 90, 87, 32 };
            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;
            foreach(int num in arr)
            {
                if(num % 2 == 0)
                {
                    sumOfEvenNumbers += num;
                }
                else
                {
                    sumOfOddNumbers += num;
                }
            }
            Console.WriteLine($"Sum of Even Numbers in a Array = {sumOfEvenNumbers}");
            Console.WriteLine($"Sum of Odd Numbers in a Array = {sumOfOddNumbers}");
        }
        public static void OddEvenSortingInArray()
        {
            int[] arr = { 23, 42, 76, 45, 90, 87, 32 };
            List<int> EvenNumber = new List<int>();
            List<int> OddNumbers = new List<int>();

            foreach(int num in arr)
            {
                if(num % 2 == 0)
                {
                    EvenNumber.Add(num);
                }
                else
                {
                    OddNumbers.Add(num);
                }
            }
            EvenNumber.AddRange( OddNumbers );
            int[] EvenNumfirst = EvenNumber.ToArray();
            Console.WriteLine("EvenNumber First : "+ String.Join(", ",EvenNumfirst));
        }
        public static void AlternateOddEvenPattern()
        {
            int[] arr = { 42, 54, 68, 80, 43, 31, 57, 79,72};
            List<int> evenNum = new List<int>();
            List<int> oddNum = new List<int>();
            foreach( int num in arr)
            {
                if (num % 2 == 0) evenNum.Add(num);
                else oddNum.Add(num);
            }
                List<int> result = new List<int>();
             int oddIndex =0 ,evenIndex =0 ;
            for(int i =0;i<arr.Length;i++) 
            {
                if (oddIndex < oddNum.Count)
                {
                    result.Add(oddNum[oddIndex]);
                    oddIndex++;
                }
                if(evenIndex < evenNum.Count)
                {
                    result.Add(evenNum[evenIndex]);
                    evenIndex++;
                }
            }
            //int[] numbers = a.ToArray();
            Console.WriteLine("aleternate order : " + String.Join(", ", result));

        }
        public static void MultipleTheEvenAndOddNumberInArray()
        {
            int[] arr = { 42, 54, 68, 80, 43, 31, 57, 79, 72 };
             int multipleEven = 1, multipleodd = 1;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    multipleEven *= num;
                }
                else
                {
                    multipleodd *= num;
                }
            }
            Console.WriteLine(multipleEven);
            Console.WriteLine(multipleodd);



        }
        /*public static void Main(string[] args)
        {
            FindOddAndEvenInRange();
            FindEvenAndOddinArrray();
            FindEvenAndOddWithoutModulus();
            EvenAndOddiNDifferentArray();
            SumOfEvenAndOddNumbersInRange();
            SumOfEvenAndOddNumbersInArray();
            OddEvenSortingInArray();
            AlternateOddEvenPattern();
            MultipleTheEvenAndOddNumberInArray();
        }*/
    }
}
