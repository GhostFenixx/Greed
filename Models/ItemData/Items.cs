namespace Greed.Models.ItemData
{
    public class Items
    {
        public bool ExamineKeys { get; set; }
        public bool AddSignalPistolToSpec { get; set; }
        public bool WeaponHeatOff { get; set; }
        public bool SMGToHolster { get; set; }
        public bool PistolToMain { get; set; }
        public bool AllExaminedItems { get; set; }
        public bool EquipRigsWithArmors { get; set; }
        public bool RemoveSecureContainerFilters { get; set; }
        public double MisfireChance { get; set; } = 1;
        public double FragmentMult { get; set; } = 1;
        public double HeatFactor { get; set; } = 1;
        public double ExamineTime { get; set; } = 1;
        public double MalfunctChanceMult { get; set; } = 1;
        public double WeightChanger { get; set; } = 1;
        public double ItemPriceMult { get; set; } = 1;
        public bool EnableCurrency { get; set; }
        public int RubStack { get; set; } = 1000000;
        public int DollarStack { get; set; } = 50000;
        public int GPStack { get; set; } = 100;
        public int EuroStack { get; set; } = 50000;
        public double AmmoLoadSpeed { get; set; } = 1;
        public double LootExp { get; set; } = 1;
        public bool EnableItems { get; set; }
        public double ExamineExp { get; set; } = 1;
        public AmmoStacks AmmoStacks { get; set; }
        public bool AmmoSwitch { get; set; }
        public bool EnableKeys { get; set; }
        public bool RemoveRaidRestr { get; set; }
        public bool RemoveBackpacksRestrictions { get; set; }
        public bool AvoidSingleKeys { get; set; }
        public bool AvoidMarkedKeys { get; set; }
        public bool AvoidResidential { get; set; }
        public bool AvoidOddKeys { get; set; }
        public double KeyUseMult { get; set; } = 1;
        public double KeycardUseMult { get; set; } = 1;

        public int KeyDurabilityThreshold { get; set; } = 40;
        public bool IDChanger { get; set; }
        public bool NoGearPenalty { get; set; }
        public string IDDefault { get; set; } = "";
        public string IDParent { get; set; } = "";
        public string IDFilter { get; set; } = "";
        public string IDPrice { get; set; } = "";
        public bool InfiniteKeys { get; set; }

        public bool InfiniteKeycards { get; set; }
        public bool RaidDrop { get; set; }
        public Items()
        {
            AmmoStacks = new AmmoStacks();
        }
    }
}
