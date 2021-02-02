using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.GameFolder
{
    public abstract class GameManager : IGameService
    {
        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.Name+" deleted successfully.");
        }

        public void SaveGame(Game game)
        {
            Console.WriteLine(game.Name + " saved successfully.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.Name + " updated successfully.");
        }
    }
}
