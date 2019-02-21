﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;

namespace Player
{
    public interface IPlayerView
    {
        void OnUpdate(float horizontal, float vertical);
    }
}