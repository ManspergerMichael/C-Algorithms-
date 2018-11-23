using System;

namespace circleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            circQueue queue = new circQueue(5);
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            queue.EnQueue(5);
            queue.EnQueue(5);
            System.Console.WriteLine(queue.isFull());
            System.Console.WriteLine(queue.DeQueue());
            System.Console.WriteLine(queue.DeQueue());
            

        }
    }

    class circQueue{
        int head{get;set;}
        int tail{get;set;}
        int size{get;set;}
        int capacity{get;set;}
        int[] arr {get;set;}

        public circQueue(int cap){
            head = 0;
            tail = 0;
            size = 0;
            capacity = cap;
            arr = new int[capacity];
        }

        public int front(){
            return arr[head];
        }
        public void EnQueue(int val){
            //if circle queue is full return false
            if((tail == capacity && head == 0)||(tail == head -1)){
                System.Console.WriteLine("Queue Full");
            }
            else if(tail == capacity && head !=0){
                tail = 0;
                arr[tail] = val;
                tail ++;
            }
            else{
                arr[tail] = val;
                tail ++;
            }
        }

        public bool isEmpty(){
            if(arr[tail] == null && arr[head] == null){
                return true;
            }
            else{
                return false;
            }
        }

        public int DeQueue(){
            if(head == capacity && tail != 0){
                int val = arr[head];
                head = 0;
                return val;
            }
            else{
                int val = arr[head];
                head ++;
                return val;
            }
        }

        public bool isFull(){
            if((head == tail -1) || (head == 0 && tail == capacity)){
                return true;
            }
            else{
                return false;
            }
        }

    }
}
