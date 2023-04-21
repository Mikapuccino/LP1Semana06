using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private int rooms;
        private Difficulty difficulty;
        
        public GameLevel(int rooms, Difficulty difficulty)
        {
            this.rooms = rooms;
            this.difficulty = difficulty;
        }
    }
}