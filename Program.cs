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


        public static string UnhideWord(string word, List<string> guess)
        {
            string hiddenWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (guess.Contains(word[i].ToString()))
                {
                    hiddenWord += word[i];
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

            string word = Console.ReadLine().ToLower();

            Console.Clear();

            int lives = 5;

            bool flag = false;

            List<string> guess = new List<string>();

            while (flag == false)
            {
                Console.WriteLine($"Word is: {UnhideWord(word, guess)}");
                Console.WriteLine($"PLAYER 2 GUESS A LETTER ({lives} Lives): ");
                guess.Add(Console.ReadLine());
                if (UnhideWord(word, guess).Contains("*") == false || lives == 0)
                {
                    switch(UnhideWord(word, guess).Contains("*"))
                    {
                        case false:
                            flag = true;
                            Console.WriteLine("Congratulations! You guessed the word!");
                            Console.ReadKey();
                            break;


                        case true:
                            flag = true;
                            Console.WriteLine("You ran out of lives. The word was: " + word);
                            Console.ReadKey();
                            break;
                    }
                    flag = true;
                }
                lives--;
            }

        }
    }
}

