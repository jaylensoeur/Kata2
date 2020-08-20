using System;

namespace Kata2
{
    class Program
    {
        private const int StartNumber = 1; 
        private const int EndNumber = 100;
        private const int FizzNumber = 3;
        private const int BuzzNumber = 5;

        static void Main(string[] args)
        {
            string[] outputs = new string[EndNumber];
            int indexLocation = 0;
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                string output = null;
                if (i % FizzNumber == 0) output = "Fizz";
                if (i % BuzzNumber == 0) output += "Buzz";
                if (output == null) output = i.ToString();
                outputs[indexLocation] = output;
                indexLocation++;
            }
            string outputsInString = String.Join(", ", outputs);
            Console.WriteLine(outputsInString);
        }
    }
}
