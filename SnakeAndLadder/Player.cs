using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Player
    {
        public int Position { get; private set; }
        public int DiceRollsCount { get; private set; }

        public Player()
        {
            Position = 0;
            DiceRollsCount = 0;
        }

        public void UpdatePosition(int move)
        {
            Position += move;
            if (Position < 0)
            {
                Position = 0;
            }
            DiceRollsCount++;
        }

        public void SetPosition(int position)
        {
            Position = position;
        }
    }
}
