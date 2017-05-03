using System;
using UnityEngine;
using Zenject;

public class GameInstaller : ScriptableObjectInstaller
{
    #region Settings

    public PlayerSettings Player;

    #endregion

    #region Settings classes

    [Serializable]
    public class PlayerSettings
    {
        public PlayerInput PlayerInput;
    }

    #endregion

    public override void InstallBindings()
    {
        Container.BindInstance(Player.PlayerInput);

        Container.Bind<PlayerInput>().AsSingle().WithArguments(Player.PlayerInput.speed).NonLazy();
        Container.Bind<IFixedTickable>().To<PlayerInput>().AsSingle().NonLazy();
    }
}