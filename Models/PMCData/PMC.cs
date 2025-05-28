namespace Greed.Models.PMCData
{
    public class PMC
    {

        public bool NameOverride { get; set; }
        public bool ForceCustomWaves { get; set; }
        public int CustomWaveChance { get; set; } = 100;
        public PMCChance PMCChance { get; set; }
        public int LevelUpMargin { get; set; } = 10;
        public int LevelDownMargin { get; set; } = 70;
        public string PMCNameList { get; set; } = "Sinistar\r\nMorgan\r\nMayoringram\r\nAssAssin\r\nGhostFenixx\r\nG10orgos\r\nFortis\r\nDaveyB0y\r\nMMX\r\nTabi\r\nJojo\r\njvs\r\ndspider\r\nHenny\r\nMylu\r\nXen0Xys\r\nShruggzilla\r\nDoddsy\r\nMoffed\r\nBeagle\r\nthorncp\r\nEagle\r\nBroCC\r\nCthulhu\r\nKaryash\r\nlilthicccums\r\nTobi\r\nEmilia\r\nParka4our\r\nDonmohnke\r\nSingularity\r\nTogay\r\nGodHimself\r\nThomaszhrets\r\nAsianLover69\r\nRodyChodes\r\nl6uc6if6er\r\nbllt\r\nSaltyDroog\r\nM_conniptions\r\ntagilla\r\nTricolorHen061\r\nWaffentrager\r\nHabit\r\nUmsirqualquerai\r\nshep\r\nCannabis\r\ntrappussy\r\nShiro\r\nChomp\r\nTheSparta\r\nLostQuasar\r\nssh\r\nLacyway\r\nKronzky\r\njbs4bmx\r\naleves\r\nFontaine\r\nCWX\r\nTwistedGA\r\nLimbo\r\nSamSWAT\r\nRevingly\r\nKattomine\r\nFox\r\nGamenator\r\nCarl\r\njrdenny1\r\nDecompresS\r\nCats\r\nAtonicX\r\nsyra\r\nStako\r\nCheiftan\r\nelectric\r\nImTheRickHere\r\nmajorlier\r\nbearPhone\r\nMasterChief\r\nThe2ndarbiter\r\ncowkiller19\r\nKarma\r\nJen14owns\r\nRubMyRubber\r\nFrumorn\r\nBuyingGF\r\nRekty\r\nRebrix\r\nDatPhatAsian\r\nChinaski\r\nChameleon\r\nNeCzar\r\nPonderingOrb\r\nSerakym\r\nArsanthania\r\nYT_Mark\r\nBeDaLek\r\nNukey\r\nOwl\r\nJoshtheOG\r\nbatkiller\r\nVampireKitten\r\nBadwolf_54\r\nJustin\r\nAgentMoulder\r\nLayerofBlubber\r\nD3ovm\r\nkiobu\r\n7AmatoR7\r\nKAcidi\r\nZ3R0\r\nSpiral\r\nXsos\r\nVortex\r\nalphakiller\r\nbiohazard\r\nli3raa\r\nDalamadur\r\ncentollojames\r\nlennyrod\r\nZooey\r\nMaoci\r\nMarchwin\r\nMiki__\r\nInnerMiddle\r\npersistent\r\nYarik85\r\nDeadLeaves\r\nSenko\r\nNexus4880\r\nSlickboi\r\nTallanX\r\ntrippy\r\nguidot\r\nJanuary\r\nCloudy\r\nMrElmoEN\r\nNekoKami\r\nDOKDOR\r\ndeathbricks\r\nHustlesofter\r\nVenican\r\nNickMillion\r\nJuncker\r\nPhantomInTime\r\nVox\r\nTraveler\r\nnimbul\r\nEreshkigal\r\nSerWolfik";
        public bool NamesEnable { get; set; }
        public bool ChancesEnable { get; set; }
        public int PMCRatio { get; set; } = 50;
        public AItoPMC AItoPMC { get; set; }
        public bool EnableConvert { get; set; }
        public bool DisableLowLevelPMC { get; set; }
        public bool LootableMelee { get; set; }
        public bool EnablePMC { get; set; }
        public PMC()
        {
            PMCChance = new PMCChance();
            AItoPMC = new AItoPMC();
        }
    }
}
