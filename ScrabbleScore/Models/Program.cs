using System;
using System.Linq;
using ScrabbleScore.Models;

namespace ScrabbleScore
{

class Program 
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Scrabble Game, please enter a word.");
        string wordFromUser = Console.ReadLine().ToLower();
        Word userWord = new Word(wordFromUser);
        string wordUser = userWord.GetWord();


        char[] arrayChar = wordUser.ToCharArray();
        int scoreUser = 0;
        char [] valueOne = {'a','e', 'i', 'o', 'u', 'r', 's', 't', 'l', 'n'};
        char [] valueTwo = {'d', 'g'};
        char [] valueThree = {'b', 'c', 'm', 'p'};
        char [] valueFour = {'f', 'h', 'v', 'w', 'y'};
        char [] valueFive = {'k'};
        char [] valueEight = {'j', 'x'};
        char [] valueTen = {'q', 'z'};

        foreach (char letter in arrayChar)
        {
            if (valueOne.Contains(letter))
            {
                scoreUser += 1;
            }
            else  if (valueTwo.Contains(letter))
            {
                scoreUser += 2;
            }
            else  if (valueThree.Contains(letter))
            {
                scoreUser += 3;
            }
            else  if (valueFour.Contains(letter))
            {
                scoreUser += 4;
            }
            else  if (valueFive.Contains(letter))
            {
                scoreUser += 5;
            }
            else  if (valueEight.Contains(letter))
            {
                scoreUser += 8;
            }
            else  if (valueTen.Contains(letter))
            {
                scoreUser += 10;
            }
            else
            {
                scoreUser += 0;
            }
             
        }
        Console.WriteLine("Your word is "+ wordUser + " and your score is : "+ scoreUser);
       





    }



}

}
