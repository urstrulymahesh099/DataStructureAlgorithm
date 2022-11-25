using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue problem Statement");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Binary Search\n2.Insertion Sorting\n3.BubbleSort\n4.AnagramDetection");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binary = new BinarySearch();
                        binary.ReadTextFile(@"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\NewFolder\BinarySearch.txt");
                        binary.BinarySearchOperation("Crazy");
                        break;

                    case 2:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 6,2,7, 5, 4,8, 1, 3 };
                        insertionSort.Sort(arr);
                        break;
                    case 4:
                        AnagramDetection anagram = new AnagramDetection();
                        anagram.CheckAnagram("LISTEN", "SILENT");
                        anagram.CheckAnagram("TOSS", "SHOT");
                        anagram.CheckAnagram("TRIANGLE", "INTEGRAL");
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }

            }

        }
    }
}