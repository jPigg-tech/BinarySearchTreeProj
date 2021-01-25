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
            // Otherwise, search down the tree 
            AddNew(rootNode, new Node(data));
        }
        public void AddNew(Node _rootNode, Node newNode)
        {                      
            if (newNode.data < _rootNode.data)
            {
                if (_rootNode.leftNode == null)
                {
                    _rootNode.leftNode = newNode;
                }
                else
                {
                    AddNew(_rootNode.leftNode, newNode);
                }
            }
            else
            {
                if (_rootNode.rightNode == null)
                {
                    _rootNode.rightNode = newNode;
                }
                else
                {
                    AddNew(_rootNode.rightNode, newNode);                   
                }
            }
        }
        public bool Search(int nodeData)
        {
            // search for a specific value within the binary search tree data structure 
            Node currentNode = rootNode;
            if (rootNode.data == nodeData)
            {
                return true;
            }           
            while (true)
            {
                if(nodeData < currentNode.data)
                {
                    if (currentNode.leftNode == null)
                    {
                        break;
                    }
                    else if (currentNode.leftNode.data == nodeData)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }
                }
                else if (nodeData > currentNode.data)
                {
                    if (currentNode.rightNode == null)
                    {
                        break;
                    }
                    else if (currentNode.rightNode.data == nodeData)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                    }
                }             
            }
            return false;
        }
    }
}
