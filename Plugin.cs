using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPA.Logging;
using System;
using SiraUtil.Zenject;
using FontSizeTweaks.Installers;


namespace FontSizeTweaks
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public static string PluginName => "FontSizeTweaks";
        public static Logger log { get; private set; }

        [Init]
        public void Init(Logger logger, Config cfgProvider, Zenjector zenjector)
        {
            log = logger;
            PluginConfig.Instance = cfgProvider.Generated<PluginConfig>();
            zenjector.Install<GameInstaller>(Location.GameCore);
        }

        [OnStart]
        public void OnApplicationStart()
        {
            log.Debug("Starting FontSizeTweaks Plugin");
        }

        [OnExit]
        public void OnApplicationQuit()
        {
            log.Debug("Stopping FontSizeTweaks Plugin");
        }
    }
}
