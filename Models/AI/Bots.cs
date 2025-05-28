namespace Greed.Models.AI
{
    public class Bots
    {
        public AIChance AIChance { get; set; }
        public BotDurability ArmorDurab { get; set; }
        public BotDurability WeaponDurab { get; set; }
        public bool EnableBots { get; set; }
        public Bots()
        {
            AIChance = new AIChance();
            ArmorDurab = new BotDurability()
            {
                PMCMin = 90,
                PMCMax = 100,
                ScavMin = 50,
                ScavMax = 100,
                BossMin = 100,
                BossMax = 100,
                FollowerMin = 90,
                FollowerMax = 100,
                MarksmanMin = 90,
                MarksmanMax = 100,
                RogueMin = 90,
                RogueMax = 100,
                RaiderMin = 90,
                RaiderMax = 100,
            };
            WeaponDurab = new BotDurability()
            {
                PMCMin = 95,
                PMCMax = 100,
                ScavMin = 85,
                ScavMax = 100,
                BossMin = 80,
                BossMax = 100,
                FollowerMin = 80,
                FollowerMax = 100,
                MarksmanMin = 60,
                MarksmanMax = 100,
                RogueMin = 80,
                RogueMax = 100,
                RaiderMin = 80,
                RaiderMax = 100,
            };
        }
    }
}
