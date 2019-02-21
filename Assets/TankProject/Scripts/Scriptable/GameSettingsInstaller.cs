using UnityEngine;
using Zenject;
using Inputs;

[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    public InputListScriptable inputListScriptable;

    public override void InstallBindings()
    {
        Debug.Log("[GameSettingsInstaller]");
        Container.BindInstance(inputListScriptable);
    }

}