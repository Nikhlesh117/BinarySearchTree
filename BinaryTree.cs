using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }
        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }
        static int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    leftCount++;
                    this.LeftTree = new BinaryTree<T>(item);
                }
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                {
                    rightCount++;
                    this.RightTree = new BinaryTree<T>(item);
                }
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }   
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }
    }
}
