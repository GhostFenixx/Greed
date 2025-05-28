namespace Greed.Models.Trading
{
    public class Traders
    {
        public Fence Fence { get; set; }
        public bool RemoveTradeLimits { get; set; }
        public int QuestRedeemDefault { get; set; } = 48;
        public int QuestRedeemUnheard { get; set; } = 72;
        public TraderMarkup TraderMarkup { get; set; }
        public TraderSell TraderSell { get; set; }
        public int MinDurabSell { get; set; } = 60;
        public bool RemoveTimeCondition { get; set; }
        public bool AllQuestsAvailable { get; set; }
        public bool RemoveBarterOffers { get; set; }
        public bool RemoveCurrencyOffers { get; set; }
        public bool IncreaseAssort { get; set; }
        public bool UnlockQuestAssort { get; set; }
        public bool EnableTraders { get; set; }
        public bool FIRRestrictsQuests { get; set; }
        public bool TradersLvl4 { get; set; }
        public bool FIRTrade { get; set; }
        public bool UnlockJaeger { get; set; }
        public bool UnlockRef { get; set; }

        public Traders()
        {
            Fence = new Fence();
            TraderMarkup = new TraderMarkup();
            TraderSell = new TraderSell();
        }
    }
}
