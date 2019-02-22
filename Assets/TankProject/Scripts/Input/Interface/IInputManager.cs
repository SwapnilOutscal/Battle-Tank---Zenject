using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Inputs
{
    public interface IInputManager
    {
        //InputScriptable GetInputType();
        void AddPlayer(IPlayerController playerController, IInputComponent inputComponent);
    }
}