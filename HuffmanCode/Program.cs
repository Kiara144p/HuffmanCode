using System;
using System.Collections.Generic;

namespace HuffmanCode {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("enter a word");
            string originWord = Console.ReadLine();

            char[] characters = originWord.ToCharArray();

            countChar(characters);
        }

        static void countChar(char[] characters) {
            List<string> numberOfcharacters = new List<string>();

            for (int i = 0; i < characters.Length; i++) {
                if (numberOfcharacters.Count == 0) {
                    numberOfcharacters.Add(characters[i] + "");
                }
                else {
                    for (int j = 0; j < numberOfcharacters.Count + 1; j++) {
                        if (numberOfcharacters[j] == characters[i] + "") {
                            Console.WriteLine(characters[i] + " alredy existed");
                        }
                        else {
                            numberOfcharacters.Add(characters[i] + "");

                            Console.WriteLine(characters[i] + " not existed, created new");
                        }
                    }
                }
            }
        }
    }
}