using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    class program
    {
        public static void Main(string[] args)
        {
            BinarySearch binary = new BinarySearch();
            binary.ReadTextFile(@"E:\Bridgelabz\LinkedListProblems\DataStructureAlgorithm\NewFolder\BinarySearch.txt");
            binary.BinarySearchOperation("Crazy");
        }
    }
}