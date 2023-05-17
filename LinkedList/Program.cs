using System;
using CustomLinkedList;
namespace LinkedList
{


    class Program { 
    
        static void Main(string[] args)
        {
            CustomLinkedList.LinkedList<string> ll = new CustomLinkedList.LinkedList<string>();

            Node<string> a = new Node<string>("AAA");
            ll.AddFirst(a);
            Node<string> b = new Node<string>("BBB");
            ll.AddFirst(b);
            Node<string> c = new Node<string>("CCC");
            ll.AddFirst(c);
            Node<string> d = new Node<string>("DDD");
            ll.AddFirst(d);
            ll.Traverse();
            ll.AddAfter(new Node<string>("xxx"), a);

            ll.Traverse();
        }
    }

}