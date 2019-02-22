using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    public interface IInputComponent
    {
        void AssignInputType(InputScriptable inputScriptable);
        float GetHorizontalVal();
        float GetVerticalVal();
        void OnUpdate();
    }
}