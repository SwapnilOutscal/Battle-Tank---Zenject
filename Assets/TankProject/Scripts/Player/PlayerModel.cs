using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerModel : IPlayerModel
    {
        private int speed = 50;
        private int health = 10;
        private int rotSpeed = 25;


        public int getHealth()
        {
            return speed;
        }

        public int getRotSpeed()
        {
            return rotSpeed;
        }

        public int getSpeed()
        {
            return health;
        }
    }
}