using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace QuidditchManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            PlayerManager playerManager = new PlayerManager();
            MatchManager matchManager = new MatchManager();
            StadiumManager stadiumManager = new StadiumManager();

            do
            {
                choice = displayMenu();
                switch (choice)
                {
                    case 1:
                        displayMatches();
                        break;
                    case 2:
                        displayStadiums();
                        break;
                    case 3:
                        displayCatchers();
                        break;
                    case 4:
                        displayGoalKeepers();
                        break;
                    case 5:
                        displayAvailablePlaces();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n");

            } while (choice != 6);
        }

        static void displayMatches()
        {
            MatchManager matchManager = new MatchManager();
            IEnumerable<string> listMatch = matchManager.GetMatchesOrderedByDate();
            int i = 1;
            foreach (string match in listMatch)
            {
                Console.WriteLine("Match n°" + i++ + " : " + match);
            }
        }

        static void displayStadiums()
        {
            StadiumManager stadiumManager = new StadiumManager();
            IEnumerable<string> listStadiums = stadiumManager.GetStadiums();
            foreach (string stadium in listStadiums)
            {
                Console.WriteLine(stadium);
            }
        }

        static void displayCatchers()
        {
            PlayerManager playerManager = new PlayerManager();
            IEnumerable<string> listCatchers = playerManager.GetCatchers();
            foreach (string catcher in listCatchers)
            {
                Console.WriteLine(catcher);
            }
        }

        static void displayGoalKeepers()
        {
            PlayerManager playerManager = new PlayerManager();
            IEnumerable<string> listGoalkeepers = playerManager.GetGoalkeepers();
            foreach (string goalkepper in listGoalkeepers)
            {
                Console.WriteLine(goalkepper);
            }
        }

        static void displayAvailablePlaces()
        {
            MatchManager matchManager = new MatchManager();
            string placeAvailable;

            do
            {
                Console.WriteLine("Which match ?");
                int index = Convert.ToInt16(Console.ReadLine()) - 1;
                placeAvailable = matchManager.GetAvailablePlaces(index);
                if (placeAvailable == null)
                    Console.WriteLine("Invalid match number");
            } while (placeAvailable == null);
            Console.WriteLine(placeAvailable + " place(s) available");
        }

        static int displayMenu ()
        {
            Console.WriteLine("Bad boys bad boys, what u'r gonna do ?");
            Console.WriteLine("1 - Comming match list ordered by date");
            Console.WriteLine("2 - Stadiums where at least one match has been played on");
            Console.WriteLine("3 - Catchers who played at least once");
            Console.WriteLine("4 - Goal Keepers younger than 17 years old");
            Console.WriteLine("5 - Available places");
            Console.WriteLine("6 - Quit");
            Console.WriteLine("\n");

            string response = Console.ReadLine();
            Console.WriteLine("");

            try 
            {
                int res = Convert.ToInt16(response);
                if (res < 1 || res > 6)
                    throw new Exception("Invalid response range");
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid choice, they'll come for you !\n");
                return displayMenu();
            }
        }
    }
}
