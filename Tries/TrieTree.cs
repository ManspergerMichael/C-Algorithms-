using System;
class TrieTree{
    TrieNode Head;
    TrieTree(){
        Head = new TrieNode(' ');
    }
    public void Add(char val){
        TrieNode newNode = new TrieNode(val);
        Head.next.Add(newNode);
    }
}