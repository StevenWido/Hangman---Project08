﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman___Project08
{
   public struct words
   {
      private List<hangmanWords> hangmanWords;


      public List<hangmanWords> GethangmanWords()
      {
         return hangmanWords;
      }
      public void SethangmanWords(List<hangmanWords> initHangmanWords)
      {
         hangmanWords = initHangmanWords;
      }
   }


   public enum hangmanWords { Bacon, Cheese, Ketchup, Lettuce, Mustard, Pickles, Tomato };

   class Program
   {
      static void Main(string[] args)
      {
         List<string> hangmanWords = new List<string>()
         { "word",
           "chicken",
           "bird",
           "whale",
           "america",
           "jasmine",
           "orange"
         };

         Random randGen = new Random();
         var idx = randGen.Next(0, hangmanWords.Count);
         string mysteryWord = hangmanWords.ElementAt(idx);
         char[] guess = new char[mysteryWord.Length];
         Console.Write("Please enter your guess: ");

         for (int p = 0; p < mysteryWord.Length; p++)
            guess[p] = '*';

         while (true)
         {
            char playerGuess = char.Parse(Console.ReadLine());
            int i = 1;
            for (int j = 0; j < mysteryWord.Length; j++)
            {
               if (playerGuess == mysteryWord[j])
                  guess[j] = playerGuess;
               // else if (playerGuess != mysteryWord[i])
                  // Console.WriteLine("Incorrect");
                  // guess[j] = "incorrect";
            }

            //if (playerGuess != mysteryWord[i])


            Console.WriteLine(guess);


         }
      }
   }
}
