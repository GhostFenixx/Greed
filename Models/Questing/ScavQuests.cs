namespace Greed.Models.Questing
{
    public class ScavQuests
    {
        public int MinKillsLR2 { get; set; } = 3;
        public int MaxKillsLR2 { get; set; } = 15;
        public int MinItems { get; set; } = 2;
        public int MaxItems { get; set; } = 5;
        public int Extracts { get; set; } = 3;
        public int Types { get; set; } = 2;
        public int Reroll { get; set; } = 0;
        public double Spread { get; set; } = 0.5;
        public int MinKillsLR1 { get; set; } = 1;
        public int MaxKillsLR1 { get; set; } = 3;
        public int Access { get; set; } = 1;
        public int QuestAmount { get; set; } = 1;
        public int Lifespan { get; set; } = 1440;
        public string Levels { get; set; } = "1,10,20,30,40,50,60";
        public string Experience { get; set; } = "0,0,0,0,0,0,0";
        public string ItemsReward { get; set; } = "2,3,3,3,3,4,4";
        public string Reputation { get; set; } = "0.02,0.02,0.03,0.03,0.04,0.04,0.05";
        public string SkillPoint { get; set; } = "10,15,20,25,30,35,40";
        public string SkillChance { get; set; } = "0,0,0,0,0,0,0";
        public string Roubles { get; set; } = "11000,20000,32000,45000,58000,70000,82000";
        public string GPcoins { get; set; } = "1,1,2,2,4,4,5";
    }
}
