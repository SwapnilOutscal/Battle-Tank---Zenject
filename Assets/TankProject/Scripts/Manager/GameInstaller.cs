using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Inputs;
using Player;

public class GameInstaller : MonoInstaller 
{
    //public InputListScriptable inputListScriptable;
    public PlayerView playerView;

    public override void InstallBindings()
    {
        Debug.Log("[GameInstaller]");
        Container.Bind(typeof(IInputManager),typeof(ITickable)).To<InputManager>().AsSingle().NonLazy();
        //Container.Bind<IPlayerModel>().To<PlayerModel>().AsTransient();
        //Container.Bind<IPlayerView>().To<PlayerView>().FromInstance(playerView);
        //Container.Bind<IInputComponent>().To<InputComponent>().AsTransient();
        //Container.Bind<IPlayerController>().To<PlayerController>().AsTransient();
        Container.Bind<PlayerView>().To<PlayerView>().FromInstance(playerView);
        Container.Bind<IPlayerManager>().To<PlayerManager>().AsSingle().NonLazy();
    }

}
