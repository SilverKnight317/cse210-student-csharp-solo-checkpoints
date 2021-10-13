using System;
using System.Collections.Generic;

namespace _05_hide_and_seek
{
    /// <summary>
    /// This class abstracts the User interface for the project. In this case
    /// it wraps calls to the Console to display and get information from the user.
    /// 
    /// In the future it could be modified to other types of Input/Output besides
    /// the Console, and it could also include checking for valid input, etc.
    /// 
    /// Stereotype:
    ///     Service Provider, Interfacer
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Displays the provided text.
        /// </summary>
        /// <param> name="text">The text to display</param>
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Gets a numeric value from the user after displaying the provided
        /// prompt text.
        /// </summary>
        /// <param name="promptText">The text to display as a prompt</param>
        /// <returns>The users choice (as an int)</returns>
        public int GetNumberChoice(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();
            // For some reason, bool and the rest didn't work, so I'll work on that after some other things.
            /*bool continue_parsing = false;
            while(!continue_parsing)
            {
                for(int i = 0; i < 1001; i++)
                {
                    string ii = i.ToString();
                    if(ii == userInput)
                    {
                        continue_parsing = true;
                    }
                    else
                    {
                        Console.WriteLine("I believe you didn't put a correct integer value in between 1 and 1000. \nPlease try again.");
                        userInput = Console.ReadLine();
                    }
                }
            }*/
            int numericChoice = int.Parse(userInput);
            return numericChoice;
            
            // One of the benefits of abstracting this user i/o into this service class
            // is that we could add extra functionality here, such as checking
            // for a valid number and re-prompting if the user entered something invalid.
            
            // For simplicity, right now, it assumes proper input.
        }
    }
}
