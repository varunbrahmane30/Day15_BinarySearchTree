using System;

namespace Day15_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Binary Search Tree ");
            
            // adding 56 into Bsst with initial value 56 as ROOT
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);

            // adding elements into BST
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);

            // display list 
            binarySearch.Display();
            Console.WriteLine();

            // searching element 63
            bool result = binarySearch.IfExists(63, binarySearch);
            Console.WriteLine(result);

       
        }
    }
}
