using DataStructuresAndDesignPatterns;
using System;

namespace DatastructuresAndDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //RemoveDuplicateFromString obj = new RemoveDuplicateFromString();
            //Console.WriteLine(obj.RemoveDuplicateCharMethod2("HappyNewYear"));

            BinarySearchTree bst = new BinarySearchTree();
            //bst.InsertMethod2(5);
            //bst.InsertMethod2(4);
            //bst.InsertMethod2(7);
            //bst.InsertMethod2(6);
            //bst.Display(bst.rootNode);

            bst.rootNode = new BinarySearchTree.Node();
            bst.rootNode.Data = 3;
            bst.rootNode.left = new BinarySearchTree.Node();
            bst.rootNode.left.Data = 2;
            bst.rootNode.right = new BinarySearchTree.Node();
            bst.rootNode.right.Data = 5;

            bst.rootNode.left.left = new BinarySearchTree.Node();
            bst.rootNode.left.left.Data = 1;
            bst.rootNode.left.right = new BinarySearchTree.Node();
            bst.rootNode.left.right.Data = 4;

            bst.Display(bst.rootNode);

            Console.WriteLine(bst.isBST(bst.rootNode));
        }
    }
}
