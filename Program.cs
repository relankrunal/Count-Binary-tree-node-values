using System;

namespace Binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node objNode = new Node(1);
            objNode.left = new Node(2)
            {
                left = new Node(5),
                right = new Node(5)
            };

            objNode.right = new Node(3);

            Console.WriteLine($"node count {objNode.Count(objNode)}");

            Console.WriteLine($"binary tree:{objNode}");
            Console.WriteLine();
        }
    }
}
