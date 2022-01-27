using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Binarytree
{
    public class Node
    {
        public Node left;
        public Node right;

        public int NodeValue { get; }

        public Node(int value)
        {
            this.NodeValue = value;
        }

        public int Count(Node root)
        {
            if (root == null)
                return 0;
            return 1 + Count(root.left) + Count(root.right);
        }
    }
}
