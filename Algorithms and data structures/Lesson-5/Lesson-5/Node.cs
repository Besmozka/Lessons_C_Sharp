namespace Lesson_5
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        public Node(int _Data)
        {
            Data = _Data;
        }

        public Node()
        {

        }
    }
}