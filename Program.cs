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

            // adding 30 - 70 into BST
            binarySearch.Insert(30);
            binarySearch.Insert(70);

            binarySearch.Display();
        }
    }
}
