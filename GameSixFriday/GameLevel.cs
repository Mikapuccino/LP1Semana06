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
        public int GetNumRooms()
        {
            return rooms.Length;
        }

        // Returns number of foes
        public int GetNumFoes()
        {
            return foes;
        }
        
        // Sets a specific foe inside the given room
        // and increments number of foes
        public void SetFoeInRoom(int room, Foe foe)
        {
            if (rooms[room] == null)
            {    
                rooms[room] = foe;
                foes += 1;
            }
        }

        // Prints every foes name and the room they are in
        public void PrintFoes()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Foe: " + (rooms[i].GetName()) +
                    ", Room: " + i);
                }
            }
        }
    }
}