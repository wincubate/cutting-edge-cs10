namespace Wincubate.CS9.Data.DataStructures
{
    public class SequenceElement<T>
    {
        public T Data { get; set; }
        public SequenceElement<T>? Next { get; set; }

        public SequenceElement(T data)
        {
            Data = data;
        }
    }

    public sealed class Sequence<T>
    {
        public SequenceElement<T>? Head { get; private set; }
        public SequenceElement<T>? Last { get; private set; }


        public Sequence()
        {
            Head = null;
        }

        public void Add(T data)
        {
            SequenceElement<T> element = new SequenceElement<T>(data);
            if (Head == null)
            {
                Head = element;
                Last = element;
            }
            else
            {
                Last!.Next = element;
                Last = Last.Next;
            }
        }
    }
}