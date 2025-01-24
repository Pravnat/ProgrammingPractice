using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammingPractice
{
    public class DuplictaesPrograme
    {
        public static void FindduplictaesNumbersinArray()
        {
            int[] arr = { 66, 89, 54, 66, 32, 89, 44, 44 };
            Dictionary<int, int> dupicatescount = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (dupicatescount.ContainsKey(arr[i]))
                {
                    dupicatescount[arr[i]]++;
                }
                else
                {
                    dupicatescount[arr[i]]=1;
                }
            }
            foreach(var pair in dupicatescount)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine(pair);
                }
            }
                
            
        }
        public static void countduplictaesstringsinArray() 
        {
            int[] arr = { 66, 89, 54, 66, 32, 89, 44, 44 };

            Dictionary<int,int> Elementcount = new Dictionary<int,int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (Elementcount.ContainsKey(arr[i]))
                {
                    Elementcount[arr[i]]++;
                }
                else
                {
                    Elementcount[arr[i]] = 1;
                }
            }
            foreach(var pair in Elementcount)
            {
                if(pair.Value > 1)
                {
                    Console.WriteLine($"Duplicate Number: {pair.Key}, Duplicat counts: {pair.Value}");
                }
            }
            
        }
        public static void RemoveDuplicatesFromSoratedArray()
        {
            int[] arr = { 66, 89, 54, 66, 32, 89, 44, 44 };
            List<int> elements = new List<int>();
            Array.Sort(arr);
            foreach(var element in arr)
            {
                if (!elements.Contains(element))
                {
                    elements.Add(element);
                }
            }
            Console.Write("Unquie elements are: "+String.Join(", ", elements));

        }
        public static void RemoveDuplicatesFromUnSoratedArray()
        {
            int[] arr = { 66, 89, 54, 66, 32, 89, 44, 44 };
            List<int> elements = new List<int>();
            foreach(var element in arr)
            {
                if (!elements.Contains(element))
                {
                    elements.Add(element);
                }
            }
            Console.Write("Unique Number are: "+ String.Join(", ", elements));
        }
        public static void DuplicatesinaStringdiffway()
        {
            string name = "praveen natarajan";
            Dictionary<char,int> charcounts = new Dictionary<char,int>();
            foreach(char c in name.Replace(" " ,""))
            {
                if (charcounts.ContainsKey(c))
                {
                    charcounts[c]++;
                }
                else
                {
                    charcounts[c] = 1;
                }

            }
            foreach (var pair in charcounts)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("Unique Number are: " + String.Join(", ", pair.Key));
                    Console.WriteLine("Unique Number are: " + String.Join(", ", pair));
                }
            }

        }
        public static void RemoveDuplicateCharinString()
        {
            string name = "praveen natarajan";
            char[] characters = name.Replace(" ","").ToCharArray();
            List<char> unique = new List<char>();
            foreach(char c in characters)
            {
                if (!unique.Contains(c))
                {
                    unique.Add(c);
                }
            }
            Console.Write("Uniquie character are : " +  String.Join(", ", unique));

        }
        public static void FindDuplicatesWordInString()
        {
            string Words = "Apple banana Apple orange kiwi kiwi";
            string[] arrWord = Words.Split(" ").ToArray();
            Dictionary<string,int> Duplicates = new Dictionary<string,int>();
            for(int i = 0; i < arrWord.Length; i++) { 
                if (Duplicates.ContainsKey(arrWord[i]))
                {
                    Duplicates[arrWord[i]]++;
                }
                else
                {
                    Duplicates[arrWord[i]] =1;
                }
            }
            foreach(var pair in Duplicates)
            {
                if (pair.Value > 1) 
                {
                    Console.WriteLine(pair);
                }
            }
        }
        public static void RemoveSuplicatesWordinString()
        {
            string Words = "Apple banana Apple orange kiwi kiwi";
            string[] arrWord = Words.Split(" ").ToArray();
            List<string> duplicates = new List<string>();
            foreach(string s in arrWord)
            {
                if (!duplicates.Contains(s))
                {
                    duplicates.Add(s);
                }
            }
            Console.WriteLine("revoved duplicates word are : " + String.Join(" ",duplicates));
        }
        public static void removeDuplicatesUsingHashSet()
        {
            int[] arr = { 66, 89, 54, 66, 32, 89, 44, 44 };
            int[] uniquiearr = new HashSet<int>(arr).ToArray();

            Console.WriteLine("Remved duplicates : "+String.Join(",",uniquiearr));
        }
        public static void removeDuplicatesinStringUsingHashSet()
        {
            string Words = "Apple banana Apple orange kiwi kiwi";
            string[] word = Words.Split(" ").ToArray();
            string[] uniquiearr = new HashSet<string>(word).ToArray();

            Console.WriteLine("Remved duplicates : " + String.Join(" ", uniquiearr));
        }
        public static void removeDuplicatesincharUsingHashSet()
        {
            string name = "praveen natarajan";
            char[] chararr = name.Replace(" ", "").ToArray();
            char[] unique = new HashSet<char>(chararr).ToArray();
            Console.WriteLine("Remved duplicates : " + String.Join(" ", unique));
        }
        /*public static void Main(string[] args)
        {
            //FindduplictaesNumbersinArray();
            //countduplictaesstringsinArray();
            //RemoveDuplicatesFromSoratedArray();
            //RemoveDuplicatesFromUnSoratedArray();
            //DuplicatesinaStringdiffway();
            //RemoveDuplicateCharinString();
            //FindDuplicatesWordInString();
            //RemoveSuplicatesWordinString();
            //removeDuplicatesUsingHashSet();
            //removeDuplicatesinStringUsingHashSet();
            removeDuplicatesincharUsingHashSet();
        }*/
    }
}
