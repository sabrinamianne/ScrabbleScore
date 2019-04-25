using System.Linq;
namespace ScrabbleScore.Models
{
    public class Word
    {
        private string _userInput;

        public Word (string userInput)
        {
            _userInput = userInput;
        }
       
        public string GetWord()
        {
            return _userInput;
        }
        
    }
        public class Check
        {
            public char [] valueOne = {'a','e', 'i', 'o', 'u', 'r', 's', 't', 'l', 'n'};
            public char [] valueTwo = {'d', 'g'};
            public char [] valueThree = {'b', 'c', 'm', 'p'};
            public char [] valueFour = {'f', 'h', 'v', 'w', 'y'};
            public char [] valueFive = {'k'};
            public char [] valueEight = {'j', 'x'};
            public char [] valueTen = {'q', 'z'};

            public bool CheckLetter(char Letter)
            {
                    if (valueOne.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueTwo.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueThree.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueFour.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueFive.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueEight.Contains(Letter))
                    {
                        return true;
                    }
                    else if (valueTen.Contains(Letter))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
            }
        }
    public class Score
    {
         private int _userScore;

        public Score (int userScore)
        {
            _userScore = userScore;
        }
       public int GetScore()
       {
           return _userScore;
       }

    }
       
    }   
