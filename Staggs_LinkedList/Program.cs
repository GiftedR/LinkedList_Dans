namespace Staggs_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList cll = new CustomLinkedList();
            string? input = "";
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine(" 1 - Add Item \n 2 - Remove Item \n 3 - Search For Name \n 4 - Print \n 5 - Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": //Add Item
                        Console.WriteLine("Insert Name: ");
                        string? addedName = Console.ReadLine();
                        cll.addItem(addedName);
                        break;
                    case "2": //Remove Item
                        Console.WriteLine("Delete Name: ");
                        string? removeName = Console.ReadLine();
                        Console.WriteLine(cll.removeItem(removeName));
                        break;
                    case "3": //Contains
                        Console.WriteLine("Find Name: ");
                        string? findName = Console.ReadLine();
                        Console.WriteLine($"{cll.containsItem(findName)}");
                        break;
                    case "4": //Print
                        Console.WriteLine(cll.printAllNodes());
                        break;
                    case "5": //Exit
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine($"Invalid Number: \"{input}\"");
                        break;
                }
            }
        }
    }
}