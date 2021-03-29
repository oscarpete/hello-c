using System;

namespace interactions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Now;
            string userFeeling = null;
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine(); //is this a comment?
            Console.WriteLine($"Hello {userName} How are you? good or bad?");
            userFeeling = Console.ReadLine();
            
            if(userFeeling == "good")
            {
                Console.WriteLine($"Hey {userName} today {todaysDate} I also feel {userFeeling}");
            }
            else
            {
                Console.WriteLine($"Well {userName} I know you are {userFeeling} and today {todaysDate} is a new day!");
            }
        }
    }
}
