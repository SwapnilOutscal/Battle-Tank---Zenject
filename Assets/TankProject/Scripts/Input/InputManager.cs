using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Player;

namespace Inputs
{
    public class InputManager : IInputManager, ITickable
    {
        private Dictionary<IPlayerController, IInputComponent> playerDictionary = new Dictionary<IPlayerController, IInputComponent>();

        //[Inject]
        private InputListScriptable inputListScriptable;

        public InputManager()
        {
            Debug.Log("[InputManager]");
            //this.inputListScriptable = inputListScriptable;
            playerDictionary = new Dictionary<IPlayerController, IInputComponent>();
        }

        public void AddPlayer(IPlayerController playerController, IInputComponent inputComponent)
        {
            playerDictionary.Add(playerController, inputComponent);
        }

        public InputScriptable GetInputType()
        {
            return inputListScriptable.inputList[Random.Range(0, inputListScriptable.inputList.Count)];

        }

        public void Tick()
        {
            if (playerDictionary.Count > 0)
            {
                foreach (IPlayerController controller in playerDictionary.Keys)
                {
                    controller.UpdateView(playerDictionary[controller].OnUpdate());
                }
            }
        }
    }
}