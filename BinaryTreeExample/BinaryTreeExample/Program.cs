using System;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinarySearchTree();
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(2);
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(5);
            binaryTree.Add(10);
            binaryTree.Add(4);

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine($"Max value: {binaryTree.MaxValue(binaryTree.Root)}");
            Console.WriteLine($"Min value: {binaryTree.MinValue(binaryTree.Root)}");

            Console.ReadLine();
        }
    }
}
