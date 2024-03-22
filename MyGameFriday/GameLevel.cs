using System;

namespace MyGameFriday
{
    public class GameLevel
    {
        private int numRooms;
        private Difficulty difficulty;
        private Enemy[] rooms_array;
        public GameLevel(int _numRooms, Difficulty _difficulty)
        {
            this.numRooms = _numRooms;
            this.difficulty = _difficulty;
            this.rooms_array = new Enemy [numRooms];
        }

        public void SetEnemyInRoom(int index_room, Enemy enemy)
        {
            rooms_array[index_room - 1] = enemy;
        }
        public Difficulty GetDifficulty()
        {
            return this.difficulty;
        }
        public int GetNumRooms()
        {
            return this.numRooms;
        }
        public int GetNumEnemies()
        {
            int contagem = 0;
            for (int i = 0; i < rooms_array.Length;i++)
            {
                if (rooms_array[i].GetType() != null)
                {
                    contagem += 1;
                }
            }
            return contagem;
        }
        public string PrintEnemies()
        {
            int contagem = 0;
            for (int i = 0; i < rooms_array.Length;i++)
            {
                if (rooms_array[i].GetType() != null)
                {
                    Console.WriteLine($"Room { i + 1}: {rooms_array[i]}");
                }
            }
            return "WIP";
        }
    }
}