using System.Collections;


namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
             st.Push(3);
            st.Push(4);
            int length=st.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("print the stack member "+ st.Pop());
            }

            Queue q1=new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(12);
            q1.Enqueue(13);
            q1.Enqueue(14);
            q1.Enqueue(15);
            for (int j = 0; j <q1.Count; j++)
            {
                Console.WriteLine("print the queue value LIFO "+q1.Dequeue());
            }
        }

    }
}
