using System;

namespace BinaryTreeExample
{
    public class Node
    {
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public void ShowData()
        {
            Console.Write($"{Data} ");
        }

    }
}
