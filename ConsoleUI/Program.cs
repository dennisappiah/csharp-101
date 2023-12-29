using BattleShipLibrary;
using BattleShipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // this class represents the user interface of the application
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();


            PlayerModel player1 = CreatePlayer();
            PlayerModel player2 = CreatePlayer();
            PlayerModel winner = null;

            do
            {


            } while(winner == null);

            Console.ReadLine();
        }
 

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Line");
            Console.WriteLine();
        }

        

        private static PlayerModel CreatePlayer()
        {
            PlayerModel player = new PlayerModel();

            // ask user for their name
            AskForName(player);

            // load up the shot 25 -grid (not responsibility of user) 
            //player.ShotGrid = 
            GameLogic.InitializeGrid(player);

            // ask user for their 5 ship placements
            PlaceShips(player);

            // clear
            Console.Clear();

            return player;
        }

        private static void AskForName(PlayerModel player)
        {
            Console.WriteLine("What is your name: ");
            
            player.PlayerName = Console.ReadLine();
        }

        private static void PlaceShips(PlayerModel player)
        {
            do
            {
                Console.WriteLine("");

                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.StoreShip(player, location);
                if (isValidLocation is false)
                {
                    Console.WriteLine("That is not a valid location");
                }

            } while(player.ShipLocations.Count < 5);
        }


        private static void DisplayResult(PlayerModel player)
        {

        }
    }
}
