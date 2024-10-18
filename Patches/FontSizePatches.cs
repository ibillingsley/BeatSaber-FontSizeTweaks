using SiraUtil.Affinity;
using System;

namespace FontSizeTweaks.Patches
{
    class FontSizePatches
    {
        public FontSizePatches(CoreGameHUDController gameHUDController)
        {
            var immediateRankUIPanel = gameHUDController.GetComponentInChildren<ImmediateRankUIPanel>();
            if (immediateRankUIPanel != null)
            {
                immediateRankUIPanel._rankText.fontSize = PluginConfig.Instance.RankFontSize;
                immediateRankUIPanel._rankText.enableWordWrapping = false;

                immediateRankUIPanel._relativeScoreText.fontSize = PluginConfig.Instance.PercentFontSize;
                immediateRankUIPanel._relativeScoreText.enableWordWrapping = false;
            }
        }
    }
}
