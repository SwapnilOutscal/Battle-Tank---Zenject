using System.Collections;
using System.Collections.Generic;
using Inputs;
using UnityEngine;

namespace Player
{
    public class PlayerController : IPlayerController
    {
        private PlayerModel playerModel;
        private PlayerView playerView;
        private InputComponent inputComponent;

        public PlayerController(GameObject _playerView)
        {
            this.playerModel = playerModel;
            playerView = GameObject.Instantiate(_playerView,Vector3.zero,Quaternion.identity).GetComponent<PlayerView>();
            inputComponent = new InputComponent();
            playerView.SetPlayerController(this);
        }

        public void UpdateView(InputData inputData)
        {
            Debug.Log("[PlayerController] PC Update");
            playerView.OnUpdate(inputData);
        }

        public IInputComponent GetInputComponent()
        {
            return inputComponent;
        }

        public IPlayerModel GetPlayerModel()
        {
            return playerModel;
        }
    }
}