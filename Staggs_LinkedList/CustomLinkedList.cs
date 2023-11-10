namespace Staggs_LinkedList
{
    internal class CustomLinkedList
    {
        private Node? _listStart;
        public void addItem(string nodeData)
        {
            Node newNode = new Node(nodeData);
            Node? _pointer = _listStart;
            if (_listStart == null)
            {
                _listStart = newNode;
                return;
            }
            if (leftGreater(_listStart.firstName, newNode.firstName))
            {
                newNode.nextNode = _listStart;
                _listStart = newNode;
                return;
            }
            while (_pointer.nextNode != null)
            {
                if (leftGreater(_pointer.nextNode.firstName, newNode.firstName))
                {
                    newNode.nextNode = _pointer.nextNode;
                    _pointer.nextNode = newNode;
                    return;
                }
                _pointer = _pointer.nextNode;
            }
            _pointer.nextNode = newNode;
        }
        public string removeItem(string nodeData)
        {
            if (_listStart == null)
            {
                return "false";
            }
            Node? foundNode = getItem(nodeData);
            if (foundNode == null)
            {
                return "";
            }
            foundNode.nextNode = foundNode.nextNode.nextNode;
            return "true";
        }
        public bool containsItem(string nodeData)
        {
            return getItem(nodeData) != null;
        }
        //Returns the node before the found node.
        private Node? getItem(string nodeData)
        {
            if (_listStart == null)
            {
                return null;
            }
            Node? _pointer = _listStart;
            while (_pointer.nextNode != null)
            {
                if (_pointer.nextNode.firstName == nodeData)
                {
                    return _pointer;
                }
                _pointer = _pointer.nextNode;
            }
            return null;
        }
        public string printAllNodes()
        {
            Stack<string> returnStack = new Stack<string>();
            Node? _pointer = _listStart;
            if (_listStart == null)
            {
                return "Linked List is empty!";
            }
            while (_pointer != null)
            {
                returnStack.Push(_pointer.firstName);
                _pointer = _pointer.nextNode;
            }
            return String.Join(" -> ", returnStack.ToArray());
        }

        private bool leftGreater(string left, string right)
        {
            int smallerIndex;
            if(left.Length<right.Length)
            {
                smallerIndex = left.Length;
            }
            else
            {
                smallerIndex = right.Length;
            }
            for (int i = 0; i < smallerIndex; i++)
            {
                if ((int)char.ToLower(left[i]) < (int)char.ToLower(right[i]))
                {
                    return true;
                } else if ((int)char.ToLower(left[i]) == (int)char.ToLower(right[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
