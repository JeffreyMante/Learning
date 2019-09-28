using System.Collections.Generic;
using DailyCodingProblems.src.Infrastructure;

namespace DailyCodingProblems.src.Solutions
{
    /// <Description>
    /// Given the root to a binary tree, implement serialize(root), 
    /// which serializes the tree into a string, and deserialize(s), 
    /// which deserializes the string back into the tree.
    ///
    /// For example, given the following Node class
    ///
    /// class Node:
    ///    def __init__(self, val, left=None, right=None):
    ///        self.val = val
    ///        self.left = left
    ///        self.right = right
    ///
    /// The following test should pass:
    ///
    /// node = Node('root', Node('left', Node('left.left')), Node('right'))
    /// assert deserialize(serialize(node)).left.left.val == 'left.left'
    /// </Description>
    public sealed class Solution0x3 : SolutionBase
    {
        public Solution0x3() : base() { }

        public override void Run()
        {
            var root = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
            var data = Serialize(root);
            var node = Deserialize(data);

            if (node.Left.Left.Data.ToString() == "left.left")
            {
                PrintLine(data);
            }
        }

        private string Serialize(Node node)
        {
            return string.Join(' ', Serialize(node, new Queue<object>()));
        }

        private Queue<object> Serialize(Node node, Queue<object> data)
        {
            if (node == null)
            {
                data.Enqueue("-1");
                return data;
            }

            data.Enqueue(node.Data);
            Serialize(node.Left, data);
            Serialize(node.Right, data);
            return data;
        }

        private Node Deserialize(string data)
        {
            return Deserialize(new Queue<object>(data.Split(' ')));
        }

        private Node Deserialize(Queue<object> data)
        {
            var value = data.Dequeue();
            if (Equals(value, "-1"))
            {
                return null;
            }

            return new Node(value, Deserialize(data), Deserialize(data));
        }
    }
}