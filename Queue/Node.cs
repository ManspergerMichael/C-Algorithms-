namespace Queue{
    
    class Node{
        public int val {get;set;}
        public Node next {get;set;}

        public Node(int value){
            val = value;
            next = null; 
        }
        public void print(){
            System.Console.WriteLine("val: "+ val);
        }
    }
}