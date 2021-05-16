using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class Menu
    {
        static void Main(string[] args)
        {
            MainMenu();
            PrintTitle();

        }

        static void MainMenu()
        {
            Console.WriteLine("===========Main Menu===========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Print("0. Exit");
        }

        static void StaffMenu()
        {
            Print("================Staff Menu================");
        }

        static void MemberMenu()
        {
            Print("===============Member Menu===============");
        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }

        private static void PrintTitle()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("");
        }
    }
}
