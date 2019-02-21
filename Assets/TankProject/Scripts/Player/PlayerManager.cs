using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;

namespace Player
{
    public class PlayerManager : IPlayerManager
    {
        private List<IPlayerController> playerControllers;
        private IInputManager inputManager;
        private PlayerView playerView;

        public PlayerManager(IInputManager inputManager, PlayerView _playerView)
        {
            this.inputManager = inputManager;
            playerView = _playerView;
            playerControllers = new List<IPlayerController>();
            SpawnPlayer();

        }

        void SpawnPlayer()
        {
            PlayerController playerController = new PlayerController(playerView.gameObject);
            playerControllers.Add(playerController);
            inputManager.AddPlayer(playerController, playerController.GetInputComponent());
        }

    }
}