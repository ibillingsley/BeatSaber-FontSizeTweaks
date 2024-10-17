using FontSizeTweaks.Patches;
using System;
using Zenject;

namespace FontSizeTweaks.Installers
{
    internal class GameInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<FontSizePatches>().AsSingle().NonLazy();
        }
    }
}
