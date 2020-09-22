using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_MyLinkedList
{
    public class Node<T>
    {
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
        public Node<T> Next { get; set; }
        public T Data { get; set; }
    }
    public class GenericList<T>
    {
        private Node<T> tail;

        public GenericList()
        {
            tail = Head = null;
        }

        public Node<T> Head { get; private set; }
        public void Add(T t)
        {
            var n = new Node<T>(t);
            if (tail == null)
            {
                Head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            var node = Head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
    }     //随意实现一个链表，这不是重点
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var max = int.MinValue;
            var min = int.MaxValue;
            var sum = 0;

            list.ForEach(s =>    //forrach是一个典型的Action泛型，返回值为空、输入参数自定
            {
                max = Math.Max(max, s);
                min = Math.Min(min, s);
                sum += s;
            }
            );

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
    }
}
