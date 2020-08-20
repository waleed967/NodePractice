using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindGame.Backend
{
    class MasterMind
    {
        public static int maxGuesses = 8;
        public static int guessCounter = 1;
        public static String[] secretCode = null;
        public static int correctPositionedGuessesCounter = 0;
        public static int correctGuessesCounter = 0;
        public static Boolean showSecretCode = false; //true if you want to show secret code to player
        public static List<int> lastValues = new List<int>();

        public static Boolean isValueDuplicate(int value)
        {
             if (lastValues.Contains(value))
                {
                    return true;
                }
            return false;
        }

        public static int UniqueRandomInt(int max)
        {
            Random rnd = new Random();
            int val = rnd.Next(max);
            while (isValueDuplicate(val))
            {
                val = rnd.Next(max);
            }
            lastValues.Add(val);
            return val;
        }
        public static String[] getRandomizeArray()
        {
           
            String[] colors = new String[6] { "Red", "Green", "Blue", "Yellow", "Violet","Orange" };
            String[] shuffled = new String[4];

            for(int i=0; i< shuffled.Length; i++)
            {
                shuffled[i] = colors[UniqueRandomInt(colors.Length)];
            }

            for (int i = 0; i < shuffled.Length; i++)
            {
                Console.WriteLine(i + " " + shuffled[i]);
            }
            return shuffled;
        }

        public static String[] getSecretCode()
        {
            String[] secretCode = getRandomizeArray();
            secretCode = secretCode.Where((source, index) => index != secretCode.Length).ToArray();
            Console.WriteLine("Secret code");
            for (int i = 0; i < secretCode.Length; i++)
            {
                Console.WriteLine(i + " " + secretCode[i]);
            }
            return secretCode;
        }

        public static void incrementGuessCounter()
        {
            guessCounter++;
        }

        public static void resetGuessCounter()
        {
            guessCounter = 1;
        }

        public static void incrementcorrectPositionedGuessesCounter()
        {
            correctPositionedGuessesCounter++;
        }

        public static void resetCorrectPositionedGuessesCounter()
        {
            correctPositionedGuessesCounter = 0;
        }

        public static void incrementCorrectGuessesCounter()
        {
            correctGuessesCounter++;
        }

        public static void resetCorrectGuessesCounterr()
        {
            correctGuessesCounter = 0;
        }
        public static void resetLastValues()
        {
            lastValues = new List<int>();
        }

    }
}
