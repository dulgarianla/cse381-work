namespace AlgorithmLib;

public static class HuffmanTree
{
    // Node class represents a node in the Huffman tree
    public class Node
    {
        public char Letter { get; set; }  // The character stored in the node
        public float Count { get; set; }  // Frequency or count of the character in the text

        public Node? Left;  // Left child node
        public Node? Right; // Right child node
    }

    // Generates a frequency profile for characters in the given text
    public static Dictionary<char, int> Profile(string text)
    {
        Dictionary<char, int> profile = new Dictionary<char, int>();
        foreach (char letter in text)
        {
            if (profile.ContainsKey(letter))
            {
                profile[letter] += 1;
            }
            else
            {
                profile[letter] = 1;
            }
        }
        return profile;
    }

    // Builds a Huffman tree based on the frequency profile
    public static Node BuildTree(Dictionary<char, int> profile)
    {
            // Initialize the queue
            var queue = new PriorityQueue<Node>();
            foreach (char letter in profile.Keys)
            {
                Node node = new Node
                {
                    Letter = letter,
                    Count = profile[letter],
                    Left = null,
                    Right = null
                };
                queue.Insert(node, node.Count);
            }

            while (queue.Size() > 1)
            {
                Node lNode = queue.Dequeue();
                Node rNode = queue.Dequeue();
                Node pNode = new Node
                {
                    Count = lNode.Count + rNode.Count,
                    Left = lNode,
                    Right = rNode
                };
                queue.Insert(pNode, pNode.Count);
            }
            return queue.Dequeue();
        }

    // Creates a mapping of characters to their Huffman codes
    public static Dictionary<char, string> CreateEncodingMap(Node root)
    {
        var map = new Dictionary<char, string>();
        CreateEncodingMapHelper(root, "", map);
        return map;
    }

    // Recursive helper function to create the encoding map
    private static void CreateEncodingMapHelper(Node node, string code, Dictionary<char, string> map)
    {
        if (node == null)
        {
            return;
        }

        if (node.Left == null && node.Right == null)
        {
            map[node.Letter] = code; // Assign Huffman code to the character
        }
        else
        {
            // Traverse left with "0" and right with "1" to build Huffman codes
            CreateEncodingMapHelper(node.Left, code + "0", map);
            CreateEncodingMapHelper(node.Right, code + "1", map);
        }
    }

    // Encodes the given text using the provided Huffman encoding map
    public static string Encode(string text, Dictionary<char, string> map)
    {
        string result = "";
        foreach (char letter in text)
        {
            result += map[letter];
        }
        return result;
    }

    // Decodes the given Huffman-encoded text using the provided Huffman tree
    public static string Decode(string text, Node tree)
    {
        Node curr_node = tree;
        string result = "";
        int index = 0;
        while (index < text.Length)
        {
            if (text[index] == '0')
            {
                curr_node = curr_node.Left;
            }
            else
            {
                curr_node = curr_node.Right;
            }

            if (curr_node.Left == null && curr_node.Right == null)
            {
                result += curr_node.Letter; // Append the decoded character
                curr_node = tree; // Reset to the root for the next character
            }

            index += 1;
        }

        return result;
    }
}
