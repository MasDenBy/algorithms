namespace LeetCode
{
    /// <summary>
    /// 706. Design HashMap
    /// </summary>
    public class MyHashMap
	{
        private const int MaxElements = 10000;
        private const int NotFoundCode = -1;

        private readonly Node[] nodes;

        public MyHashMap()
        {
            this.nodes = new Node[MaxElements];
        }

        public void Put(int key, int value)
        {
            var hash = GetHash(key);

            this.nodes[hash] = this.PutNode(this.nodes[hash], key, value);
        }

        public int Get(int key)
        {
            var hash = GetHash(key);
            var node = this.nodes[hash];

            while (node != null)
            {
                if (node.key == key)
                    return node.value;

                node = node.next;
            }

            return NotFoundCode;
        }

        public void Remove(int key)
        {
            var hash = GetHash(key);
            this.nodes[hash] = this.RemoveNode(this.nodes[hash], key);
        }

        private static int GetHash(int key) => key.GetHashCode() % MaxElements;

        private Node PutNode(Node node, int key, int value)
        {
            if (node == null) return new Node(key, value);

            if (node.key == key) node.value = value;
            else node.next = this.PutNode(node.next, key, value);

            return node;
        }

        private Node RemoveNode(Node node, int key)
        {
            if (node == null) return null;

            if (node.key == key) return node.next;
            else node.next = this.RemoveNode(node.next, key);

            return node;
        }

        private class Node
        {
            public int key;
            public int value;
            public Node next;

            public Node(int key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }
    }
}