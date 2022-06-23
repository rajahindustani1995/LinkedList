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
            linkedList.AppendNode(node1);
            linkedList.AppendNode(node2);
            linkedList.ChangePosition(30, 56);
            linkedList.Display();
        }
    }
}
