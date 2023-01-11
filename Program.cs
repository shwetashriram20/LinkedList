namespace LinkedList
{
    class Program
{
    public static void Main(String[] args)
    {
        LinkedList list = new LinkedList();

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(40);
            list.insertNode(70);
            list.printNodes();


            Console.WriteLine("the list is: " + list.getListSize());
            Console.WriteLine("Delete node from 2nd location");
            list.deleteNNode(2);
            list.printNodes();

        }
    }

}
          

