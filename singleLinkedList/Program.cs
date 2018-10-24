using System;

namespace singleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SLL!");
            SinglyLinkedList DaList = new SinglyLinkedList();
            DaList.Add(1);
            DaList.Add(2);
            DaList.Add(3);
            DaList.PrintValues();
            DaList.Remove();
            DaList.PrintValues();

        }
    }
}
