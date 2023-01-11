namespace LinkedList
{
    class Program
{
    public static void Main(String[] args)
    {
        LinkedList list = new LinkedList();


            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();


            Console.WriteLine("Delete node");
            list.deleteNode();
            list.printNodes(); 

        }
    }

}
          

