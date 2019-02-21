using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    [CreateAssetMenu(fileName = "Input", menuName = "Scriptables/Input", order = 1)]
    public class InputScriptable : ScriptableObject
    {
        public KeyCode moveForward;
        public KeyCode moveBackward;
        public KeyCode moveLeft;
        public KeyCode moveRight;
    }
}