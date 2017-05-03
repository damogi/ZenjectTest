using System;
using Zenject;

public class PlayerInstaller : ScriptableObjectInstaller<PlayerInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<PlayerInput>().AsSingle().WithArguments(PlayerInputSettings.speed);
        Container.Bind<IFixedTickable>().To<PlayerInput>().AsSingle();
    }

    [Serializable]
    public class PlayerInputSettings
    {
        public static float speed;
    }
}