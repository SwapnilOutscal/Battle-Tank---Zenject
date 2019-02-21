using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;

namespace Player
{
    public interface IPlayerController
    {
        IPlayerModel GetPlayerModel();
        IInputComponent GetInputComponent();
        void Move(float horizontal, float vertical);
    }
}