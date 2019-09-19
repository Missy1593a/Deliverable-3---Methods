/*
 Author: Amrita Amnay
 Date: 19 September 2019
 Comments: This console asks users to enter thier first and last name and outputs the user's name plus a hello before the name.
 */

using System;
namespace Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for first name
            Console.WriteLine("Please enter your first name: ");
            string firstname = Console.ReadLine();
            //Asks user for last name
            Console.WriteLine("Please Enter your last name: ");
            string lastname = Console.ReadLine();
            //Combines first and last name
            string wholename = firstname + " " + lastname;
            //outputs the user's input for first and last name 
            //Greets user in an excited manner
            Console.WriteLine("Hello" +  " " + wholename + "!");
            //Closes window with any key
            Console.ReadKey();
        } // End of Main
    }
}

