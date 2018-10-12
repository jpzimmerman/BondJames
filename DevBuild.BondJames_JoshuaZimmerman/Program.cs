using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBuild.Utilities;

namespace DevBuild.BondJames_JoshuaZimmerman
{
    class Program
    {
        static void Main(string[] args)
        {
            string startingUserName = "", startingUserNameSwapped = "";
            YesNoAnswer userAnswer = YesNoAnswer.AnswerNotGiven;

            Console.Write("***********************************************************\n" +
                          "*               Dev.Build(2.0) - Bond James               *\n" +
                          "***********************************************************\n\n");

            while (true)
            {
                while (startingUserName.Trim() == "" || !startingUserName.Contains(' '))
                {
                    Console.Write("Please enter your first and last name: ");
                    startingUserName = Console.ReadLine().Trim();
                }
                startingUserNameSwapped = SwapNames(startingUserName);
                Console.WriteLine("Swapped name is {0}", startingUserNameSwapped);
                startingUserName = "";

                userAnswer = UserInput.GetYesOrNoAnswer("Do you wish to enter another name? (y/n or yes/no) ");
                switch (userAnswer)
                {
                    case YesNoAnswer.Yes: userAnswer = YesNoAnswer.AnswerNotGiven; continue;
                    case YesNoAnswer.No: userAnswer = YesNoAnswer.AnswerNotGiven; return ;
                }
            }

        }

        /// <summary>
        /// This function swaps a user's first and last names, returns a string containing the user's swapped names
        /// </summary>
        /// <param name="unswappedFullName">User's given name and surname separated by a space (' ') character, in either order</param>
        /// <returns></returns>
        static string SwapNames(string unswappedFullName)
        {
            string[] tempName = unswappedFullName.Split(' ');
            string nameResult = "";

            //Let's check to see if a user entered at least a first and a last name
            //Just in case the user enters a middle name, let's only take what we assume are the first and last names
            if (tempName.Length >= 2)               
            {
                nameResult = tempName[tempName.Length - 1] + " " + tempName[0];
            }
            
            return nameResult;
        }
    }
}
