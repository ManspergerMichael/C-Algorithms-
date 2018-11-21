using System;

namespace circleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class circQueue{
        int head{get;set;}
        int tail{get;set;}
        int capacity{get;set;}
        int[] arr {get;set;}

        public circQueue(int cap){
            head = 0;
            tail = 0;
            capacity = cap;
            arr = new int[capacity];
        }

        public int front(){
            return arr[head];
        }
        public void EnQueue(int val){
            //if circle queue is full return false
            if((tail == capacity-1 && head == 0)||(tail == head -1)){
                System.Console.WriteLine("Queue Full");
            }
            if(tail == capacity -1 && head !=0){
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
            if(head == capacity -1 && tail != 0){
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

    }
}
