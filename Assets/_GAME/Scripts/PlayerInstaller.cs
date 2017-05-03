using System;
using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{   
    #region Install functions

    private void PlayerInputInstall()
    {
        Container.Bind<PlayerInput>().AsSingle();
        Container.Bind<IFixedTickable>().To<PlayerInput>().AsSingle().NonLazy();
    }

    private void PlayerAimingInstall()
    {
        Container.Bind<PlayerAiming>().AsSingle();
        Container.Bind<IInitializable>().To<PlayerAiming>().AsSingle().NonLazy();
        Container.Bind<ITickable>().To<PlayerAiming>().AsSingle().NonLazy();
    }

    #endregion

    public override void InstallBindings()
    {
        PlayerInputInstall();
        PlayerAimingInstall();
    }
}
