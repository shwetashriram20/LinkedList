namespace LinkedList
{
    class Program
{
    public static void Main(String[] args)
    {
        LinkedList list = new LinkedList();

            list.insertNode(56);

            list.insertNode(70);
            list.printNodes();

            Console.WriteLine("Add 30 at 1st Location");
            list.insertN(30, 1);
            list.printNodes();
            

        }
    }

}
          

