using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.river_raid
{
    class Game
    {
        public int score;
        public int health;
        public int heroX;
        public int heroY;
        public int herox;
        public int heroy;
        public int bulletcount = 0, bulletenmeyX, bulletenemyY, count, bulltmovey, bulltmovex;
        public Game(int score, int health, int heroX, int heroY, int herox, int heroy)
        {
            this.score = score;
            this.health = health;
            this.heroX = heroX;
            this.heroY = heroY;
            this.herox = herox;
            this.heroy = heroy;
            int bulletcount = 0, bulletenmeyX, bulletenemyY, count, bulltmovey, bulltmovex;
        }
    }
}
