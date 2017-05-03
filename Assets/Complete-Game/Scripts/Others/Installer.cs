using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<PlayerController>().AsSingle();
        Container.Bind<GameController>().AsSingle();
        Container.Bind<BGScroller>().AsSingle().NonLazy();
        Container.Bind<Boundary>().AsSingle().NonLazy();
    }
}
