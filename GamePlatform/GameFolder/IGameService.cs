using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.GameFolder
{
    public interface IGameService
    {
        public void SaveGame(Game game);
        public void UpdateGame(Game game);
        public void DeleteGame(Game game);
      
    }
}
