using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Practice_ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up question to try again
            string userContinue = "y";
            while (userContinue != "n")
            {

                //take in a string a store in a var
                Console.WriteLine("Please enter a string.");
                string userAnswer = Console.ReadLine();

                //put string into an array
                char[] userAnswerArray = userAnswer.ToCharArray();

                //reverse array
                Array.Reverse(userAnswerArray);

                //print array in reverse order
                Console.WriteLine(new string(userAnswerArray));

                //The while-loop at the top comes full circle
                //ask user if they want to try again
                //Validation to make sure they enter y or n
                userContinue = "";
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to try again? y/n");
                    userContinue = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
