using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace HuffmanCode {
    class Program {
         static BinaryTree huffman = new BinaryTree();
        static void Main(string[] args) {
            List<Letter> letters = new List<Letter>();

            Console.WriteLine("enter a word");
            string originText = Console.ReadLine();

            letters = generateList(originText);

            letters = sortList(letters);

           
        List<Node> HuffmanTree = new List<Node>();
        
            foreach (var var in letters) {
                
                Node node = new Node(var);
                HuffmanTree.Add(node);
            }
            HuffmanTree = buildTree(HuffmanTree);
            huffman.Root = HuffmanTree[0];
            
            
            for (int i = 0; i < letters.Count; i++) {
                Console.WriteLine(letters.Count + "   " + letters[i].Symbol + "   " + letters[i].Amount);
            }

            for (int i  = 0; i < HuffmanTree.Count; i++) {
                Console.WriteLine(HuffmanTree.Count + "   " + HuffmanTree[i].Value.Symbol + "   " + HuffmanTree[i].Value.Amount);
                
            }
        }

        static List<Letter> generateList(string originText) {
            bool isPresent;

            List<Letter> letters = new List<Letter>();
            char[] characters = originText.ToCharArray();

            foreach (var var in characters) {
                isPresent = false;

                for (int i = 0; i < letters.Count; i++) {
                    if (letters[i].Symbol == var) {
                        letters[i].Amount++;
                        isPresent = true;
                    }
                }

                if (!isPresent) {
                    Letter letter = new Letter(var);
                    letters.Add(letter);
                }
            }

            return letters;
        }

        static List<Node> buildTree(List<Node> huffmanTree) {

            if (huffmanTree.Count == 1) {
                return huffmanTree;
            }
                
            huffmanTree.Sort();
            
            Node value1 = huffmanTree[0];
            Node value2 = huffmanTree[1];
            
            Letter letter = new Letter(' ', value1.Value.Amount + value2.Value.Amount, null);
            Node node = new Node(letter, value1, value2);
            
            huffmanTree.Add(node);
            huffmanTree.Remove(value1);
            huffmanTree.Remove(value2);

            buildTree(huffmanTree);
            return huffmanTree;
        }

        static List<Letter> sortList(List<Letter> letters) {
           
            letters.Sort();

            return letters;
        }

        static string getCoding(char letter) {

            huffman.searchInTree(letter);
            
            
            
            return " ";
        }
    }
}