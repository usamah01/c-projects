using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNumber = 0;
            string firstName = String.Empty;
            string lastName = String.Empty;
            decimal weeklySalary = 0;
            char position = '\0';
            bool isPremierLeagueFootballer = true;
            bool isInternationalFootballer = true;

            Console.WriteLine("Please enter the identity number for this player");

            playerNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the player's first name");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the player's last name");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the weekly salary of the player");

            weeklySalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the position of the player('G' for Goalkeeper, 'D' for Defender, 'M' for Midfielder and S for Striker)");

            position = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("True or False, the player plays in the Premier League?");

            isPremierLeagueFootballer =  Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("True or False, the player also plays international football?");

            isInternationalFootballer = Convert.ToBoolean(Console.ReadLine());
        }
    }
}
