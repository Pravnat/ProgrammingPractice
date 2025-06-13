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
         public static void Squencenumber()
        {
            string input = "aaabbcccaaa";
         int c =1;
         string r ="";
         for(int i =1;i<=input.Length-1;i++){
             if(input[i] == input[i-1]){
                 c++;
             }else{
                 r +=input[i-1]+c.ToString();
                 c=1;
             }
         }
         r +=input[input.Length-1]+c.ToString();
         Console.WriteLine(r);
        }
         public static void Firstnonrepeatedcharacter()
        {
            sstring str = "swiss";
 
        for (int i = 0; i < str.Length; i++) {
            char ch = str[i];
            if (str.IndexOf(ch) == str.LastIndexOf(ch)) {
                Console.WriteLine("First non-repeated character: " + ch);
                return;
            }
        }
        Console.WriteLine("No First non-repeated character");
        }
        public static void Firstrepeatedcharacter()
        {
            sstring str = "swiss";
 
        for (int i = 0; i < str.Length; i++) {
            char ch = str[i];
            if (str.IndexOf(ch) != str.LastIndexOf(ch)) {
                Console.WriteLine("First repeated character: " + ch);
                return;
            }
        }
        Console.WriteLine("No First repeated character");
        }
        public static void anagram(){
            string str1 = "listen";
        string str2 = "silent";

        // Optional: handle case-insensitivity and trim spaces
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        if (arr1.SequenceEqual(arr2))
        {
            Console.WriteLine("Anagram");
        }
        else
        {
            Console.WriteLine("Not Anagram");
        }
    }

        }
        public static void Main(string[] args)
        {
            GivenNumisPrime();
        }
    }
}
