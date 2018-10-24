using System;
public class SinglyLinkedList{
    public SllNode Head;
    public SinglyLinkedList(){
        this.Head = null;
    }

    //add a node
    public void Add(int value){
        SllNode newNode = new SllNode(value);
        if(Head == null){
            Head = newNode;
        }
        else{
            SllNode runner = Head;
            while(runner.Next != null){
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }
    public void Remove(){
        SllNode runner = Head;
        while(runner.Next.Next != null){
            runner = runner.Next;
        }
        runner.Next = null;
    }

    public void PrintValues(){
        SllNode runner = Head;
        while(runner != null){
            System.Console.WriteLine(runner.Value);
            runner = runner.Next;
        }
    }
    public SllNode Find(int value){
        SllNode runner = Head;
        while(runner.Value != value){
            if(runner == null){
                return null;
            }
            runner = runner.Next;
        }
        return runner;
    }
    public void RemoveAt(int Value){
        
    }
}