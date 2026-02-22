using System;
using System.Collections.Generic;
using System.Text;

namespace A_6_3_CallQueue
{
    internal class Node<T>
    {

        public T Data;
        public Node<T>? Next;

        // Constructor
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

    }
}
