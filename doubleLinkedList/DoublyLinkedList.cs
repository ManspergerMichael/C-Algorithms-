public class DoublyLinkedList
{
    public DllNode Head;
    public DllNode Tail;
    public int count = 0;
    public DoublyLinkedList(){
        Head = null;
        Tail = null;
    }
    public void Add(int value){
        DllNode newNode = new DllNode(value);
        if(Head == null){
            Head = newNode;
            Tail = Head;
            this.count ++;
        }
        else{
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
            this.count ++;
        }
    }
    public void display(){
        DllNode runner = Head;
        while(runner != null){
            System.Console.WriteLine(runner.Value);
            runner = runner.Next;
        }
    }
    public bool remove(int value){
        DllNode runner = Head;
        while(runner != null){
            if(runner.Value == value){
                runner.Prev.Next = runner.Next;
                runner.Next.Prev = runner.Prev;
                this.count --;
                return true;
            }
            runner = runner.Next;
        }
        return false;
    }
    public void reverse(){
        DllNode start = this.Head;
        DllNode temp = null;
        while(start != null){
            //swap the nodes
            temp = start.Next;
            start.Next = start.Prev;
            start.Prev = temp;
            //if at the head of list set head to the swapped node
            if(start.Prev == null){
                Head = start;
            }
            //move to the next node
            //after swap next becomes previous
            start = start.Prev;
        }
    }
    
}
