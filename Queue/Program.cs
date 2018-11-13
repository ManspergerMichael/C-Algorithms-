using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            SLQueue queue = new SLQueue();
            //System.Console.WriteLine(queue.isEmpty());
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            //System.Console.WriteLine(queue.Contains(3));
            //Node temp = queue.DeQueue();
            //temp.print();
            //System.Console.WriteLine(queue.Front());
            //System.Console.WriteLine(queue.isEmpty());
            System.Console.WriteLine(queue.size());
            
        }

        public bool compaire(SLQueue q1, SLQueue q2){
            Node runner1 = q1.head;
            Node runner2 = q2.head;
            while(runner1 != null && runner2 != null){
                if(runner1.val != runner2.val){
                    return false;
                }
                runner1 = runner1.next;
                runner2 = runner2.next;
            }
            return true;
        }
        public void RemoveMin(SLQueue queue){
            int min = queue.head.val;
            Node runner = queue.head;
            while(runner != null){
                if(runner.val < min){
                    min = runner.val;
                }
                runner = runner.next;
            }
            runner = queue.head;
            while(runner != null){
                if(runner.next.val == min){
                    runner.next = runner.next.next;
                }
            }
        }
    }
}
