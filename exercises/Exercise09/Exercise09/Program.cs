using System;
using System.Collections.Generic;
using System.Collections;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            int userResponse = 9;
            userResponse = Util.printUI();

            while (userResponse!= 0)
            {
                if (userResponse == 1)
                {
                    Util.GetNewUser();
                    userResponse = Util.printUI();
                }

                else if (userResponse == 2)
                {
                    Util.AuthenticateUser();
                    userResponse = Util.printUI();

                }
                else if (userResponse == 3)
                {
                    Util.PrintUsers();
                    userResponse = Util.printUI();
                }
                else if (userResponse == 4)
                    System.Environment.Exit(0);
                else
                {
                    Console.WriteLine("Sorry, I didn't understand what you wanted to do.");
                    userResponse = Util.printUI();
                }
            };
            System.Environment.Exit(0);
        }
    }
}
