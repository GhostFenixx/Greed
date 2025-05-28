namespace Greed.Models.Questing
{
    public class Quests
    {
        public bool EnableQuestsMisc { get; set; }
        public double QuestCostMult { get; set; } = 1;
        public bool QuestRepToZero { get; set; }
        public DailyQuests DailyQuests { get; set; }
        public DailyQuests WeeklyQuests { get; set; }
        public bool EnableQuests { get; set; }
        public ScavQuests ScavQuests { get; set; }
        public Quests()
        {
            ScavQuests = new ScavQuests();
            DailyQuests = new DailyQuests()
            {
                MinKillsLR1 = 2,
                MinKillsLR2 = 5,
                MinKillsLR3 = 5,
                MinItems = 2,
                MaxKillsLR1 = 4,
                MaxKillsLR2 = 15,
                MaxKillsLR3 = 20,
                MaxItems = 5,
                Extracts = 3,
                Access = 5,
                QuestAmount = 3,
                Lifespan = 1440,
                Spread = 0.5,
                Types = 6,
                Reroll = 2,
                Levels = "1,10,20,30,40,50,60",
                Experience = "1000,2000,8000,13000,19000,24000,30000",
                Reputation = "0.01,0.01,0.02,0.02,0.03,0.03,0.03",
                ItemsReward = "2,4,5,5,5,5,5",
                Roubles = "11000,20000,32000,45000,58000,70000,82000",
                GPcoins = "3,3,6,6,8,8,10",
                SkillChance = "0,0.01,0.05,0.1,0.1,0.15,0.15",
                SkillPoint = "10,15,20,25,30,35,40"
            };
            WeeklyQuests = new DailyQuests()
            {
                MinKillsLR1 = 10,
                MinKillsLR2 = 15,
                MinKillsLR3 = 20,
                MinItems = 2,
                MaxKillsLR1 = 20,
                MaxKillsLR2 = 40,
                MaxKillsLR3 = 40,
                MaxItems = 5,
                Extracts = 10,
                Access = 15,
                QuestAmount = 1,
                Lifespan = 10080,
                Spread = 0.5,
                Types = 6,
                Reroll = 0,
                Levels = "1,10,20,30,40,50,60",
                Experience = "5000,15000,27000,80000,142000,220000,290000",
                Reputation = "0.02,0.03,0.04,0.04,0.05,0.05,0.05",
                ItemsReward = "4,5,5,6,6,7,7",
                Roubles = "20000,50000,175000,350000,540000,710000,880000",
                GPcoins = "10,10,16,16,20,30,35",
                SkillChance = "0,0.05,0.1,0.15,0.2,0.2,0.2",
                SkillPoint = "25,35,45,50,55,60,65"
            };
        }
    }
}
