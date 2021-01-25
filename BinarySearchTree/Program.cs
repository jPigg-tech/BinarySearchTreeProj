using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(5);
            tree.Add(7);
            tree.Add(2);
            tree.Add(3);
            tree.Add(9);

            tree.Search(9);

            Console.WriteLine(tree.Search(2));
            Console.ReadLine();
        }
    }
}
