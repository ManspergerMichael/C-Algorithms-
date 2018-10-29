using System;
using System.Collections.Generic;
class TrieNode{
    public char value;
    public List<TrieNode> next;
    public TrieNode(char val){
        value = val;
        next = new List<TrieNode>();
    }

}