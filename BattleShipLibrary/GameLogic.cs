using BattleShipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLibrary
{
    public static class GameLogic
    {
        private static void AddGridSpot(PlayerModel player, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel()
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            player.ShotGrid.Add(spot);
        }

        public static void InitializeGrid(PlayerModel player)
        {
            List<string> letters = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };
         
            List<int> numbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach(string letter in letters)
            {
                foreach(int number in numbers)
                {
                    AddGridSpot(player, letter, number);
                }
            }

        } 

        public static bool StoreShip(PlayerModel player, string location)
        {
           throw new NotImplementedException();
        }
     
    }
}
