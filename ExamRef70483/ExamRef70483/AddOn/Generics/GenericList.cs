using System;
using System.Collections.Generic;

namespace ExamRef70483.AddOn.Generics
{
    public class GenericList<T>
    {
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                Next = null;
                Data = t;
            }

            public Node Next { get; set; }

            // T as private member data type.

            // T as return type of property.
            public T Data { get; set; }
        }

        private Node head;

        // constructor
        public GenericList()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            var n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public static void Test()
        {
            var list = new GenericList<int>();
            for (var i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}