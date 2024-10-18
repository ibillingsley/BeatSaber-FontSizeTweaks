namespace FontSizeTweaks
{
    public class PluginConfig
    {
        public static PluginConfig Instance { get; set; }

        public float RankFontSize { get; set; } = 24F; // Default 33
        public float PercentFontSize { get; set; } = 18F; // Default 12
    }
}
