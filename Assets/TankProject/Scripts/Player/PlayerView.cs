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

        public void OnUpdate(float horizontal, float vertical)
        {
            transform.Translate(horizontal * Vector3.forward * playerController.GetPlayerModel().getSpeed() * Time.deltaTime);
            transform.Rotate(vertical * Vector3.one * 3f * playerController.GetPlayerModel().getRotSpeed() * Time.deltaTime);
        }
    }
}
