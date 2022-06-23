namespace DataStructure
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);
            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);
            Console.WriteLine("Delete Last element");
            linkedList.DeleteNodeAtLast();
            linkedList.Display();
        }
    }
}
