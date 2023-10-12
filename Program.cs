using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        public static string ListToString(List<string> list)
        {
            string word = "";
            for (int i = 0; i < list.Count; i++)
            {
                word += list[i];
            }
            return word;
        }


        public static string unhideWord(string word, char guess)
        {
            string hiddenWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess)
                {
                    hiddenWord += guess.ToString();
                }
                else
                {
                    hiddenWord += "*";
                }
            }
            return hiddenWord;
        }

        static void Main(string[] args)
        {
            Console.Write("Player 1 Enter a Word: ");

            string word = Console.ReadLine();

            int lives = word.Length;

            char guess = ' ';
            bool flag = false;

            while (flag == false)
            {
                Console.WriteLine($"Word is: {unhideWord(word, guess)}");
                Console.Write($"PLAYER 2 GUESS A LETTER ({lives} Lives): ");
                guess = char.Parse(Console.ReadLine());
            }
        }
    }
}

