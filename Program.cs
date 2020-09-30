using System;

namespace c_sharp_practice
{
   class Program
   {
      static void Main(string[] args)
      {
         int computerCount = 0;
         int userCount = 0;
         int rounds = 5;
         // keep track of wins
         string[] options = { "paper", "rock", "scissars" };
         // 
         // make computer choose
         // make function to generate random numbers 
         // allow user to type commands in the console
         // compare values
         // Console.WriteLine("Hello World!");
         Console.Write("choose option to play : ");
         string userChoice = Console.ReadLine();
         string computerOptions = generateNumber(options);

         if (computerCount < rounds || userCount < rounds)
         {
            if (userChoice == computerOptions)
            {
               Console.WriteLine("Its a tied");
            }
            else if (userChoice == "paper" && computerOptions == "rock")
            {
               Console.WriteLine("user Chose: " + userChoice);
               Console.WriteLine("computer Chose: " + computerOptions);
               userCount++;
               Console.Write("choose option to play : ");
            }
            else if (userChoice == "rock" && computerOptions == "scissars")
            {
               Console.WriteLine("user Chose: " + userChoice);
               Console.WriteLine("computer Chose: " + computerOptions);
               userCount++;
            }
            else if (userChoice == "scissars" && computerOptions == "paper")
            {
               Console.WriteLine("user Chose: " + userChoice);
               Console.WriteLine("computer Chose: " + computerOptions);
               userCount++;
            }

            if (computerOptions == "paper" && userChoice == "rock")
            {
               Console.WriteLine("Computer Chose: " + computerOptions);
               Console.WriteLine("User Chose: " + userChoice);
               computerCount++;
            }
            else if (computerOptions == "rock" && userChoice == "scissars")
            {
               Console.WriteLine("Computer Chose: " + computerOptions);
               Console.WriteLine("User Chose: " + userChoice);
               computerCount++;
            }
            else if (computerOptions == "scissars" && userChoice == "paper")
            {
               Console.WriteLine("Computer Chose: " + computerOptions);
               Console.WriteLine("User Chose: " + userChoice);
               computerCount++;
            }
         }
         else
         {
            if (userCount >= rounds)
            {
               Console.WriteLine("User Won!");
            }
            else
            {
               Console.WriteLine("Computer Won!");
            }
         }





      }
      static string generateNumber(string[] option)
      {
         System.Random random = new System.Random();
         int num = random.Next(3);
         return option[num];
      }

   }
}
