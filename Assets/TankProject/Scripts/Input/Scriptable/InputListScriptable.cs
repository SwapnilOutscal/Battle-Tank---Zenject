using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    [CreateAssetMenu(fileName = "InputList",menuName = "Scriptables/InputList",order = 1)]
    public class InputListScriptable : ScriptableObject
    {
        public List<InputScriptable> inputList;
    }
}