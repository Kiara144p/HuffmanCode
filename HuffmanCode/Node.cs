using System;

namespace HuffmanCode {
    public class Node : IComparable {

        
        private Letter value;
        private Node left;
        private Node right;

        public Node(Letter value, Node left, Node right) {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        
        public Node(Letter value) {
            this.value = value;
            left = null;
            right = null;
        }

        public Letter Value {
            get => value;
            set => this.value = value;
        }

        public Node Left {
            get => left;
            set => left = value;
        }

        public Node Right {
            get => right;
            set => right = value;
        }
        
        public int CompareTo(object obj) {
            
            Node otherNode = obj as Node;
            
            return this.Value.Amount.CompareTo(otherNode.Value.Amount);
            
        }
    }
}