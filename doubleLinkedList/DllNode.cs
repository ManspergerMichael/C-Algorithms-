using System;
public class DllNode
{
    public int Value;
    public DllNode Next;
    public DllNode Prev;
    public DllNode(int val) 
    {
        this.Value = val;
        Next = null;
        Prev = null;
    }
}
