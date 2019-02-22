using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    public class InputComponent : IInputComponent
    {
        private InputScriptable inputScriptable;
        private float horizontalVal=0, verticalVal=0;



        public float GetHorizontalVal()
        {
            return horizontalVal;
        }

        public float GetVerticalVal()
        {
            return verticalVal;
        }

        public InputComponent()
        {
            Debug.Log("[InputComponenet]");
        }

        public void OnUpdate()
        {
            MoveF();
            MoveB();
            MoveR();
            MoveL();
        }

        void MoveF()
        {
            if (Input.GetKeyDown(inputScriptable.moveForward))
                horizontalVal = 1;
            else if (Input.GetKeyUp(inputScriptable.moveForward))
                horizontalVal = 0;
        }

        void MoveB()
        {
            if (Input.GetKeyDown(inputScriptable.moveBackward))
                horizontalVal = -1;
            else if (Input.GetKeyUp(inputScriptable.moveBackward))
                horizontalVal = 0;
        }

        void MoveL()
        {
            if (Input.GetKeyDown(inputScriptable.moveLeft))
                verticalVal = -1;
            else if (Input.GetKeyUp(inputScriptable.moveLeft))
                verticalVal = 0;
        }

        void MoveR()
        {
            if (Input.GetKeyDown(inputScriptable.moveRight))
                verticalVal = 1;
            else if (Input.GetKeyUp(inputScriptable.moveRight))
                verticalVal = 0;
        }

        public void AssignInputType(InputScriptable inputScriptable)
        {
            this.inputScriptable = inputScriptable;
            Debug.Log("[InputComponenet]" + inputScriptable.name);
        }
    }
}