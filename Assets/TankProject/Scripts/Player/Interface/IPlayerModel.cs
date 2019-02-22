using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public interface IPlayerModel
    {
        int getSpeed();
        int getHealth();
        int getRotSpeed();
    }
}