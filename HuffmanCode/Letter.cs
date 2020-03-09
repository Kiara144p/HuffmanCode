using System;

namespace HuffmanCode {
    public class Letter : IComparable {
        private char symbol;
        private int amount;
        private string coding;

        public Letter(char symbol, int amount, string coding) {
            this.symbol = symbol;
            this.amount = amount;
            this.coding = coding;
        }

        public Letter(char symbol) {
            this.symbol = symbol;
            amount = 1;
            coding = " ";
        }

        public char Symbol {
            get => symbol;
            set => symbol = value;
        }

        public int Amount {
            get => amount;
            set => amount = value;
        }

        public string Coding {
            get => coding;
            set => coding = value;
        }


        public int CompareTo(object obj) {
            
            Letter otherLetter = obj as Letter;
            
                return this.Amount.CompareTo(otherLetter.Amount);
            
        }
    }
}