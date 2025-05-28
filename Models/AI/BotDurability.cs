namespace Greed.Models.AI
{
    public class BotDurability
    {
        public int PMCMax { get; set; } = 100;
        public int FollowerMax { get; set; } = 100;
        public int BossMax { get; set; } = 100;
        public int MarksmanMax { get; set; } = 100;
        public int ScavMax { get; set; } = 100;
        public int RogueMax { get; set; } = 100;
        public int RaiderMax { get; set; } = 100;
        public int PMCMin { get; set; } = 95;
        public int FollowerMin { get; set; } = 90;
        public int BossMin { get; set; } = 90;
        public int MarksmanMin { get; set; } = 90;
        public int ScavMin { get; set; } = 50;
        public int RogueMin { get; set; } = 90;
        public int RaiderMin { get; set; } = 90;
    }
}
