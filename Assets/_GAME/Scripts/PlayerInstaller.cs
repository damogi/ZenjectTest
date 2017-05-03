using System;
using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{   
    #region Install functions

    private void PlayerInputInstall()
    {
        Container.Bind<PlayerInput>().AsSingle().NonLazy();
        Container.Bind<IFixedTickable>().To<PlayerInput>().AsSingle().NonLazy();
    }

    #endregion

    public override void InstallBindings()
    {
        PlayerInputInstall();
    }
}