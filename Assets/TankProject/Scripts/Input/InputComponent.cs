using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    public class InputComponent : IInputComponent
    {
        private InputScriptable inputScriptable;
        private float horizontalVal=0, verticalVal=0;

        public InputComponent(/*InputManager inputManager*/)
        {
            Debug.Log("[InputComponenet]");
            //inputScriptable = inputManager.GetInputType();
        }

        public void OnUpdate()
        {
            MoveF();
            MoveB();
            MoveR();
            MoveL();

            InputData inputData = new InputData();

            inputData.horizontalVal = horizontalVal;
            inputData.verticalVal = verticalVal;

            return inputData;
        }

        void MoveF()
        {
            if (Input.GetKeyDown(KeyCode.W))
                horizontalVal = 1;
            else if (Input.GetKeyUp(KeyCode.W))
                horizontalVal = 0;
        }

        void MoveB()
        {
            if (Input.GetKeyDown(KeyCode.S))
                horizontalVal = -1;
            else if (Input.GetKeyUp(KeyCode.S))
                horizontalVal = 0;
        }

        void MoveL()
        {
            if (Input.GetKeyDown(KeyCode.A))
                verticalVal = -1;
            else if (Input.GetKeyUp(KeyCode.A))
                verticalVal = 0;
        }

        void MoveR()
        {
            if (Input.GetKeyDown(KeyCode.D))
                verticalVal = 1;
            else if (Input.GetKeyUp(KeyCode.D))
                verticalVal = 0;
        }

    }
}