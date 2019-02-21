using System.Collections;
using System.Collections.Generic;
using Inputs;
using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        IPlayerController playerController;

        public void SetPlayerController(IPlayerController playerController)
        {
            this.playerController = playerController;
        }

        public void OnUpdate(InputData inputData)
        {
            transform.Translate(inputData.verticalVal * Vector3.forward * playerController.GetPlayerModel().getSpeed() * Time.deltaTime);
        }
    }
}
