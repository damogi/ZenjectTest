using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
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

    private void AsteroidsInstall()
    {
        Container.Bind<Asteroid>().AsTransient().NonLazy();
    }

    private void BulletsInstall()
    {
        Container.Bind<Bullet>().AsTransient().NonLazy();
    }

    private void InstallWaveInstaller()
    {
        Container.Bind<WaveSpawner>().AsSingle().NonLazy();
        Container.Bind<IInitializable>().To<WaveSpawner>();
        Container.Bind<ITickable>().To<WaveSpawner>();
    }

    #endregion

    public override void InstallBindings()
    {
        //Player installs
        PlayerInputInstall();
        PlayerAimingInstall();

        AsteroidsInstall();
        BulletsInstall();
    }
}