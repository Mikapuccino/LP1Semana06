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

        // Returns room difficulty
        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        // Returns number of rooms
        public int GetRooms()
        {
            return rooms.Length;
        }

        // Returns number of foes
        public int GetFoes()
        {
            return foes;
        }
        
        // Sets a specific foe inside the given room
        // and increments number of foes
        public void SetFoeInRoom(int room, Foe foe)
        {
            rooms[room] = foe;
            foes += 1;
        }
    }
}