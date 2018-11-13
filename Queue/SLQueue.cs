namespace Queue{
    class SLQueue{
        public Node head {get;set;}
        public Node tail {get;set;}

        public SLQueue(){
            head = null;
            tail = null;
        }

        public void EnQueue(int val){
            Node NewNode = new Node(val);
            if(head == null && tail == null){
                head = NewNode;
                tail = NewNode;
            }
            else{
                tail.next = NewNode;
                tail = NewNode;
            }
        }
        public Node DeQueue(){
            Node temp = head;
            head = head.next;
            return temp;
        }
        public int Front(){
            return head.val;
        }
        public bool Contains(int val){
            Node runner = head;
            while(runner != null){
                if(runner.val == val){
                    return true;
                }
                runner = runner.next;
            }
            return false;
        }
        public bool isEmpty(){
            if(head == null && tail == null){
                return true;
            }
            else{
                return false;
            }
        }
        public int size(){
            int count = 0;
            Node runner = head;
            while(runner != null){
                count ++;
                runner = runner.next;
            }
            return count;
        }

        
    }
}