using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndDesignPatterns
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int Data;
            public Node left;
            public Node right;
        }

        public Node rootNode;
        public void Display(Node root)
        {
            if (root != null)
                Console.Write(" " + root.Data);

            if(root.left != null)
            {
                Display(root.left);
            }

            if(root.right != null)
            {
                Display(root.right);
            }
        }

        public void InsertMethod1(int value)
        {
            Node newNode = new Node();
            newNode.Data = value;
            if (rootNode == null)
                rootNode = newNode;

            else
            {
                Node parent = rootNode;
                
                while(parent != null)
                {
                    if(parent.Data > value)
                    {
                        if (parent.left != null)
                            parent = parent.left;
                        else
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (parent.right != null)
                            parent = parent.right;
                        else
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void InsertMethod2(int value)
        {
            Node newNode = new Node();
            newNode.Data = value;
            if (rootNode == null)
                rootNode = newNode;

            else
            {
                Node parent = rootNode;

                while (parent != null)
                {
                    if (parent.Data > value)
                    {
                        if (parent.left != null)
                            parent = parent.left;
                        else
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (parent.right != null)
                            parent = parent.right;
                        else
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        //Question: A program to check if a binary tree is BST or not
        public bool isBST(Node root, Node l, Node r)
        {
            if(root != null)
            {
                if(root.left != null)
                {
                    if (root.Data <= l.Data)
                        return false;
                    isBST(root, l.left, r.right);
                }
                if (root.right != null)
                {
                    if (root.Data >= r.Data)
                        return false;
                    isBST(root.left, r.left, r.right);
                }
            }
            return true;
        }
    }
}
