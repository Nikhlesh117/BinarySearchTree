namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

            BinaryTree<int> bst = new BinaryTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }

    }      
        
}