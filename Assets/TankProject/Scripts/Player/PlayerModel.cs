using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerModel : IPlayerModel
    {
        private int speed = 5;
        private int health = 10;


        public int getHealth()
        {
            return speed;
        }

        public int getSpeed()
        {
            return health;
        }
    }
}