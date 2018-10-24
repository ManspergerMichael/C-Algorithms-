using System;

namespace doubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DLL!");
            DoublyLinkedList DaList = new DoublyLinkedList();
            
            DaList.Add(1);
            DaList.Add(2);
            DaList.Add(3);
            //System.Console.WriteLine(DaList.remove(2));
            //DaList.display();
            DaList.Add(4);
            DaList.Add(5);
            DaList.reverse();
            DaList.display();
        }
    }
}
