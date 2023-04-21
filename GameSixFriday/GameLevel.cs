using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Foe[] rooms;
        private int foes;
        private Difficulty difficulty;
        
        public GameLevel(int rooms, Difficulty difficulty)
        {
            this.rooms = new Foe[rooms];
            this.difficulty = difficulty;
            foes = 0;
        }

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetRooms()
        {
            return rooms.Length;
        }

        public int GetFoes()
        {
            return foes;
        }
        
        public void SetFoeInRoom()
        {

        }
    }
}