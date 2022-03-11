using System;

namespace Week4
{
    public class Test
    {
        public static void Main()
        {
            GenericLink<int> genericLink = new GenericLink<int>();
            for(int i = 0; i < 10; i++)
            {
                genericLink.add(i);
            }
            try
            {
                genericLink.ForEach(m => Console.WriteLine(m));
                int max = genericLink.Head.Data;
                genericLink.ForEach((i) => { if (i > max) max = i; });
                int min = genericLink.Head.Data;
                genericLink.ForEach((i) => { if (i < min) min = i; });
                int sum = 0;
                genericLink.ForEach((i) => sum += i);
                Console.WriteLine($"max is {max}, min is {min}, sum is {sum}.");
            }
            catch { Console.WriteLine("Err"); }
        }
    }
    public class Node<T>
    {
        public Node<T> Next;
        public T Data { get; set; }
        public Node(T d)
        {
            Next = null;
            Data = d;
        }
    }
    public class GenericLink<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericLink()
        {
            head = tail = null;
        }

        public Node<T> Head { get { return head; } }
        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(tail == null)
            {
                tail = head = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void ForEach(Action<T> func)
        {
            if(head == null)
            {
                throw new InvalidOperationException("This link is empty.");
            }
            Node<T> pointer = head;
            while(pointer != null)
            {
                func(pointer.Data);
                pointer = pointer.Next;
            }
        }
    }
}