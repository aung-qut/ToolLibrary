using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.Write("You password please: ");
            StringBuilder passwordBuilder = new StringBuilder();
            bool continueReading = true;
            char newLineChar = '\r';
            while (continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char passwordChar = consoleKeyInfo.KeyChar;

                if (passwordChar == newLineChar)
                {
                    continueReading = false;
                }
                else
                {
                    passwordBuilder.Append(passwordChar.ToString());
                }
            }
            Console.WriteLine();
            Console.Write("Your password in plain text is {0}", passwordBuilder.ToString());
        }
    }
}
