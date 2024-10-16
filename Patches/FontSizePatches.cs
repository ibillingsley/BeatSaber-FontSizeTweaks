using SiraUtil.Affinity;
using System;

namespace FontSizeTweaks.Patches
{
    class FontSizePatches : IAffinity
    {
        public FontSizePatches(CoreGameHUDController gameHUDController)
        {
            var immediateRankUIPanel = gameHUDController.GetComponentInChildren<ImmediateRankUIPanel>();
            immediateRankUIPanel._rankText.fontSize = PluginConfig.Instance.RankFontSize;
            immediateRankUIPanel._relativeScoreText.fontSize = PluginConfig.Instance.PercentFontSize;
        }
    }
}
