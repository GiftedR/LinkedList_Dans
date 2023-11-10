namespace Staggs_LinkedList
{
    internal class Node
    {
        public Node nextNode;
        public string firstName {
            get;
            set;
        }
        public Node(string nFirstName) { 
            firstName = nFirstName;
        }
    }
}
