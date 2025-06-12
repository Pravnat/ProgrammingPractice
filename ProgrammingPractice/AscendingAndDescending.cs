using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    public class AscendingAndDescending
    {
        public static void sortingUsingTupleSortString()
        {
            string[] arr = { "Orange", "fig", "guava", "banana", "apple" };
            for(int i = 0;i<arr.Length;i++){
                for(int j = i+1;j<arr.Length;j++){
                    if(arr[i].Length>arr[j].Length){
                        (arr[i],arr[j]) = (arr[j],arr[i]);
                    }
                }
            }
            Console.WriteLine(String.Join(", ",arr));
        }
         public static void sortingUsingTupleSortInt()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12 };
             for(int i = 0;i<arr.Length;i++){
                 for(int j = i+1;j<arr.Length;j++){
                     if(arr[i]<arr[j]){
                         (arr[i],arr[j]) = (arr[j],arr[i]);
                     }
                 }
             }
             Console.WriteLine(String.Join(", ",arr));
         }
        public static void AscedingAndDescendingInArray()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12 };
            int temp;
            foreach (int num in arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach(int aes in arr)
            {
                Console.Write(aes + " ");
            }
            Console.WriteLine();
            foreach (int num in arr)
            {
                for(int i = 0;i < arr.Length; i++)
                {
                    for(int j = i + 1;j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach(int des in arr)
            {
                Console.Write(des + " ");
            }
        }
        public static void SortaStringOfArraybasedOntheirLength()
        {
            string[] arr = { "Orange", "fig", "guava", "banana", "apple" };
            string temp;
            foreach(string t in arr)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    for(int j =i + 1; j < arr.Length; j++)
                    {
                        if (arr[i].Length > arr[j].Length) 
                        {
                            temp = arr[i];

                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach(string iteam in arr)
            {
                Console.WriteLine(iteam);
            }
            foreach (string t in arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i].Length < arr[j].Length)
                        {
                            temp = arr[i];

                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach (string iteam in arr)
            {
                Console.WriteLine(iteam);
            }
        }
        public static void FindLargestAndSmallestlengthinArray()
        {
            string[] arr = { "Orange", "fig", "guava", "banana", "apple" };
            string largelength = arr[0];
            string smalllength = arr[0];

            foreach(string iteam in arr) 
            {
                if (iteam.Length < smalllength.Length)
                {
                    smalllength = iteam;
                }
                if(iteam.Length > largelength.Length)
                {
                    largelength = iteam;
                }
            }
            Console.WriteLine(largelength);
            Console.WriteLine(smalllength);
        }
        public static void SortAnArrayofOddandEven()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12 };
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int temp;

            foreach(int n in arr)
            {
                for(int i =0; i < arr.Length; i++)
                {
                    for(int j = i + 1; j< arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach(int num in arr)
            {
                if (num % 2 == 0)  even.Add(num); 
                else  odd.Add(num); 
            }
            odd.AddRange(even);
            int[] res = odd.ToArray();
            Console.WriteLine(String.Join(", ",res));
        }
        public static void SortAscendingunSortDuplicate()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12,77,998 };
            int temp;
            foreach(int num in arr)
            {
                for(int i =0; i < arr.Length; i++)
                {
                    for(int j = i + 1;j< arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            int[] uniqu = new HashSet<int>(arr).ToArray();
            foreach(int num in uniqu)
            {
                Console.Write(num +" ");
            }
        }
        public static void SortAscendingunSortDuplicatediff()
        {
            int[] arr = { 3, 56, 77, 42, 998, 345, 652, 12, 77, 998 };
            List<int> unique = new List<int>();
            foreach(int nu in arr)
            {
                if (!unique.Contains(nu))
                {
                    unique.Add(nu);
                }
            }
            int[] uniarr= unique.ToArray();
            int temp;
            foreach (int num in unique)
            {
                for (int i = 0; i < uniarr.Length; i++)
                {
                    for (int j = i + 1; j < uniarr.Length; j++)
                    {
                        if (uniarr[i] > uniarr[j])
                        {
                            temp = uniarr[i];
                            uniarr[i] = uniarr[j];
                            uniarr[j] = temp;
                        }
                    }
                }
            }
            foreach (int num in uniarr)
            {
                Console.Write(num + " ");
            }
        }
        public static void SortStringOfArray()
        {
            string[] arr = { "fig", "kiwi", "apple", "watermelon", "banana" };
            for(int i = 0; i < arr.Length; i++)
                {
                    for(int j = i + 1;j < arr.Length; j++)
                    {
                        if (arr[i].CompareTo(arr[j])> 0) 
                        {
                            (arr[i],arr[j]) =(arr[j],arr[i]);
                        }
                    }
                }
        
            
                Console.WriteLine(String.Join(",",arr));
        }
        /*public static void Main(string[] args)
        {
            //AscedingAndDescendingInArray();
            //SortaStringOfArraybasedOntheirLength();
            //FindLargestAndSmallestlengthinArray();
            //SortAnArrayofOddandEven();
            //SortAscendingunSortDuplicate();
            //SortAscendingunSortDuplicatediff();
            //SortStringOfArray();
        }*/
    }
}
