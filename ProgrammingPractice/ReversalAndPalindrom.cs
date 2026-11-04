using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    public class ReversalAndPalindrom
    {
        public static void ReversalOfString()
        {
            string name = "Praveen natarajan";
            string result = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                result += name[i];
            }
            Console.WriteLine(result);
        }
        public static void reversalofWord()
        {
            string name = " Praveen Natarajan";
            string[] arrname = name.Split(' ');
            string reverse = "";
            for (int i = arrname.Length - 1; i >= 0; i--)
            {
                reverse += arrname[i] + " ";
            }
            Console.WriteLine(reverse);
        }
        public static void RevereachcharinaWord()
        {
            string name = " Praveen Natarajan";
            string[] arrname = name.Split(" ");
            string reverse = "";
            foreach (string word in arrname)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }
                reverse += " ";
            }
            Console.WriteLine(reverse);
        }
        public static void palindromeofString()
        {
            string name = "Madam";
            string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            if (reverse.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is a palindrom");
            }
        }
        public static void reverseStringinaArray()
        {
            string[] arr = { "apple", "banana", "kiwi" };

            List<string> Reversed = new List<string>();
            foreach (string word in arr)
            {
                string revese = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    revese += word[i];

                }
                Reversed.Add(revese);

            }
            Console.WriteLine("Reversed string are " + String.Join(",", Reversed));

        }
        public static void ReversaLofInt()
        {
            int num = 12345;
            int revrese = 0;
            while (num != 0)
            {
                int digit = num % 10;
                revrese = revrese * 10 + digit;
                num /= 10;
            }
            Console.WriteLine(revrese);
        }
        public static void ReversalOdIntintArray()
        {
            int[] arr = { 123, 456, 743, 232, 434 };
            int[] reverse = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                int rev = 0;
                while(number != 0)
                {
                    int d = number % 10;
                    rev = rev * 10 + d;
                    number /= 10;
                }
                reverse[i] = rev;
            }
            foreach(int i in reverse) Console.Write(i +" ");
        }
        public static void PalindromofIntArray()
        {
            int[] arr = { 123, 456, 743, 232, 434 };
            int[] reversalarr = new int[arr.Length];
            for(int i =0;i< arr.Length; i++)
            {
                int number = arr[i];
                int rev = 0;
                while(number != 0)
                {
                    int d = number % 10;
                    rev = rev * 10 + d;
                    number /= 10;
                }
                reversalarr[i] = rev;
            }
                for(int i = 0;i< arr.Length; i++)
                {
                    if (arr[i] == reversalarr[i])
                    {
                        Console.WriteLine(arr[i] +" is a palindrome");
                    }
                }
                
            
        }

        /*public static void Main()
        {
            //ReversalOfString();
            //reversalofWord();
            //RevereachcharinaWord();
            //palindromeofString();
            //reverseStringinaArray();
            //ReversaLofInt();
            //ReversalOdIntintArray();
            PalindromofIntArray();
        }*/
        
    }
}
