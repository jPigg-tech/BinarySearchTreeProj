using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        // represent the Binary Search Tree data structure

        // Member Variables (Has A)
        public Node rootNode;

        // Constructor (Spawner)
        public BinarySearchTree()
        {
            rootNode = null;
        }
        // Member Methods (Can Do)
        public void Add(int data)
        {
            // allow the adding of a new node(with data) to the binary search tree data structure
            // If the tree is empty
            if (rootNode == null)
            {
                rootNode = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            
        }
        public void Search(Node rootNode, Node newNode)
        {
            // search for a specific value within the binary search tree data structure

        }
    }
}
