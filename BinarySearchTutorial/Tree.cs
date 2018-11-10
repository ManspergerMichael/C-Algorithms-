namespace BinarySearchTutorial{
    public class Tree{
        Node top;

        public Tree(){
            top = null;
        }
        public Tree(int initial){
            top = new Node(initial);
        }

        public void Add(int value){
            //non-recursive add
        }
        public void AddRc(int value){
            //recursive add
        }
        private void AddR(ref Node N, int value){
            //private recursive search to add now node
        }
        public void Print(ref string newString){
            //write out the tree in sorted order to the string newstring
            //implement using recursion
        }
    }
}