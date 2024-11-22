namespace Greed
{
 internal class MainClass
 {
  public class MainConfig
  {
   public string PresetNotes { get; set; } = "";
   public Items Items { get; set; }
   public Hideout Hideout { get; set; }
   public Traders Traders { get; set; }
   public Loot Loot { get; set; }
   public Player Player { get; set; }
   public Raids Raids { get; set; }
   public Fleamarket Fleamarket { get; set; }
   public Services Services { get; set; }
   public Quests Quests { get; set; }
   public CSM CSM { get; set; }
   public Scav Scav { get; set; }
   public Bots Bots { get; set; }
   public PMC PMC { get; set; }
   public Custom Custom { get; set; }

   public MainConfig()
   {
    Items = new Items();
    Hideout = new Hideout();
    Traders = new Traders();
    Loot = new Loot();
    Player = new Player();
    Raids = new Raids();
    Fleamarket = new Fleamarket();
    Services = new Services();
    Quests = new Quests();
    CSM = new CSM();
    Scav = new Scav();
    Bots = new Bots();
    PMC = new PMC();
    Custom = new Custom();
   }

  }
  public class Custom
  {
   public bool EnableCustom { get; set; }
   public bool LoggerIntoServer { get; set; }
   public bool DisableSPTFriend { get; set; }
   public bool DisableCommando { get; set; }

   public bool DisablePMCMessages { get; set; }

   public bool CustomCheck1 { get; set; }
   public bool CustomCheck2 { get; set; }
   public bool CustomCheck3 { get; set; }
   public bool CustomCheck4 { get; set; }

   public int CustomNumber1 { get; set; } = 12345;
   public int CustomNumber2 { get; set; } = 12345;
   public int CustomNumber3 { get; set; } = 12345;
   public int CustomNumber4 { get; set; } = 12345;
  }
  public class AIChance
  {
   public int KolontayStreets { get; set; } = 25;
   public int KolontayGZ { get; set; } = 45;
   //public int PartisanCustoms { get; set; } = 100;
   public int PartisanShoreline { get; set; } = 10;
   public int PartisanWoods { get; set; } = 10;
   public int PartisanLighthouse { get; set; } = 10;

   public int Kaban { get; set; } = 25;
   public int TagillaNight { get; set; } = 25;
   public int TrioLighthouse { get; set; } = 25;
   public int TrioShoreline { get; set; } = 25;
   public int TrioWoods { get; set; } = 25;
   public int Zryachiy { get; set; } = 100;
   public int CultistCustoms { get; set; } = 10;
   public int CultistShoreline { get; set; } = 20;
   public int Trio { get; set; } = 25;
   public int RaiderLab { get; set; } = 45;
   public int RaiderReserve { get; set; } = 40;
   public int CultistFactory { get; set; } = 2;
   public int CultistWoods { get; set; } = 20;
  public int CultistGroundZero { get; set; } = 44;
   public int Rogue { get; set; } = 70;
   public int Tagilla { get; set; } = 25;
   public int Shturman { get; set; } = 25;
   public int Glukhar { get; set; } = 35;
   public int Sanitar { get; set; } = 25;
   public int Reshala { get; set; } = 25;
   public int Killa { get; set; } = 35;
  }

  public class Airdrops
  {
   public AirdropContents Mixed { get; set; }
   public AirdropContents Medical { get; set; }
   public AirdropContents Barter { get; set; }
   public AirdropContents Weapon { get; set; }
   public int Sandbox_air { get; set; } = 20;
   public int Streets_air { get; set; } = 20;
   public int AirtimeMin { get; set; } = 1;
   public int AirtimeMax { get; set; } = 5;
   public int Lighthouse_air { get; set; } = 20;
   public int Bigmap_air { get; set; } = 25;
   public int Interchange_air { get; set; } = 20;
   public int Shoreline_air { get; set; } = 20;
   public int Reserve_air { get; set; } = 20;
   public int Woods_air { get; set; } = 25;

   public Airdrops()
   {
    Mixed = new AirdropContents()
    {
     ArmorMin = 1,
     ArmorMax = 5,
     PresetMin = 3,
     PresetMax = 5,
     BarterMin = 15,
     BarterMax = 35,
     CratesMin = 1,
     CratesMax = 2,
    };
    Medical = new AirdropContents()
    {
     ArmorMin = 0,
     ArmorMax = 0,
     PresetMin = 0,
     PresetMax = 0,
     BarterMin = 17,
     BarterMax = 28,
     CratesMin = 0,
     CratesMax = 0,
    };
    Barter = new AirdropContents()
    {
     ArmorMin = 0,
     ArmorMax = 0,
     PresetMin = 0,
     PresetMax = 0,
     BarterMin = 20,
     BarterMax = 35,
     CratesMin = 0,
     CratesMax = 0,
    };
    Weapon = new AirdropContents()
    {
     ArmorMin = 3,
     ArmorMax = 6,
     PresetMin = 6,
     PresetMax = 8,
     BarterMin = 11,
     BarterMax = 22,
     CratesMin = 0,
     CratesMax = 2,
    };

   }
  }
  public class AirdropContents
  {
   public int ArmorMin { get; set; }
   public int ArmorMax { get; set; }
   public int BarterMin { get; set; }
   public int BarterMax { get; set; }
   public int PresetMin { get; set; }
   public int PresetMax { get; set; }
   public int CratesMin { get; set; }
   public int CratesMax { get; set; }
  }


  public class AItoPMC
  {
   public int CursedToPMC { get; set; } = 20;
   public int SnipertoPMC { get; set; } = 0;
   public int ScavToPMC { get; set; } = 30;
   public int RogueToPMC { get; set; } = 5;
   public int RaiderToPMC { get; set; } = 7;
  }

  public class AmmoStacks
  {
   public int MarksmanRound { get; set; } = 40;
   public int RifleRound { get; set; } = 60;
   public int ShotgunRound { get; set; } = 20;
   public int PistolRound { get; set; } = 50;
  }

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

  public class Cases
  {
   public Case GKeychain { get; set; }
   public Case KeycardHolderCase { get; set; }
   public Case InjectorCase { get; set; }
   public Case Holodilnick { get; set; }
   public Case PistolCase { get; set; }
   public Case DocumentsCase { get; set; }
   public Case Keytool { get; set; }
   public Case SiccCase { get; set; }
   public Case ThiccWeaponCase { get; set; }
   public Case ThiccItemsCase { get; set; }
   public Case MedicineCase { get; set; }
   public Case DogtagCase { get; set; }
   public Case MagazineCase { get; set; }
   public Case AmmunitionCase { get; set; }
   public Case WeaponCase { get; set; }
   public Case ItemsCase { get; set; }
   public Case GrenadeCase { get; set; }
   public Case WZWallet { get; set; }
   public Case SimpleWallet { get; set; }
   public Case MoneyCase { get; set; }
   public Case LuckyScav { get; set; }

   public Cases()
   {
    GKeychain = new Case()
    {
     Height = 2,
     Width = 2,
     Filter = false
    };
    KeycardHolderCase = new Case()
    {
     Height = 3,
     Width = 3,
     Filter = false
    };
    InjectorCase = new Case()
    {
     Height = 3,
     Width = 3,
     Filter = false
    };
    Holodilnick = new Case()
    {
     Height = 8,
     Width = 8,
     Filter = false
    };
    PistolCase = new Case()
    {
     Height = 3,
     Width = 4,
     Filter = false
    };
    DocumentsCase = new Case()
    {
     Height = 4,
     Width = 4,
     Filter = false
    };
    Keytool = new Case()
    {
     Height = 4,
     Width = 4,
     Filter = false
    };
    SiccCase = new Case()
    {
     Height = 5,
     Width = 5,
     Filter = false
    };
    ThiccWeaponCase = new Case()
    {
     Height = 15,
     Width = 6,
     Filter = false
    };
    ThiccItemsCase = new Case()
    {
     Height = 14,
     Width = 14,
     Filter = false
    };
    MedicineCase = new Case()
    {
     Height = 7,
     Width = 7,
     Filter = false
    };
    DogtagCase = new Case()
    {
     Height = 10,
     Width = 10,
     Filter = false
    };
    MagazineCase = new Case()
    {
     Height = 7,
     Width = 7,
     Filter = false
    };
    AmmunitionCase = new Case()
    {
     Height = 7,
     Width = 7,
     Filter = false
    };
    WeaponCase = new Case()
    {
     Height = 10,
     Width = 5,
     Filter = false
    };
    ItemsCase = new Case()
    {
     Height = 8,
     Width = 8,
     Filter = false
    };
    GrenadeCase = new Case()
    {
     Height = 8,
     Width = 8,
     Filter = false
    };
    WZWallet = new Case()
    {
     Height = 2,
     Width = 2,
     Filter = false
    };
    SimpleWallet = new Case()
    {
     Height = 2,
     Width = 2,
     Filter = false
    };
    MoneyCase = new Case()
    {
     Height = 7,
     Width = 7,
     Filter = false
    };
    LuckyScav = new Case()
    {
     Height = 14,
     Width = 14,
     Filter = false
    };
   }
  }

  public class Case
  {
   public int Height { get; set; }
   public int Width { get; set; }
   public bool Filter { get; set; }
  }

  public class CharXP
  {
   public int ScavKill { get; set; } = 80;
   public double ScavHMult { get; set; } = 1.1;
   public int PMCKill { get; set; } = 175;
   public double PMCHMult { get; set; } = 1.2;
  }

  public class CSM
  {
   public bool EnableCases { get; set; }
   public bool EnableSecureCases { get; set; }
   public bool CustomPocket { get; set; }
   public Pockets Pockets { get; set; }
   public Cases Cases { get; set; }
   public SecureContainers SecureContainers { get; set; }
   public bool EnableCSM { get; set; }

   public CSM()
   {
    Pockets = new Pockets();
    SecureContainers = new SecureContainers();
    Cases = new Cases();
   }
  }

  public class DailyQuests
  {
   public int MinKillsLR3 { get; set; }
   public int MaxKillsLR3 { get; set; }
   public int MinKillsLR2 { get; set; }
   public int MaxKillsLR2 { get; set; }
   public int MinItems { get; set; }
   public int MaxItems { get; set; }
   public int Extracts { get; set; }
   public int Types { get; set; }
   public double Spread { get; set; }
   public int MinKillsLR1 { get; set; }
   public int MaxKillsLR1 { get; set; }
   public int Access { get; set; }
   public int QuestAmount { get; set; }
   public int Lifespan { get; set; }

   public string Levels { get; set; }
   public string Experience { get; set; }
   public string ItemsReward { get; set; }
   public string Reputation { get; set; }
   public string SkillPoint { get; set; }
   public string SkillChance { get; set; }
   public string Roubles { get; set; }
   public string GPcoins { get; set; }


  }


  public class DiedHealth
  {
   public bool Saveeffects { get; set; } = true;
   public bool Savehealth { get; set; } = true;
   public double Health_blacked { get; set; } = 0.1;
   public double Health_death { get; set; } = 0.3;
  }

  public class DynamicOffers
  {
   public int ExpireThreshold { get; set; } = 1400;
   public int BundleOfferChance { get; set; } = 6;
   public int Stack_min { get; set; } = 10;
   public int PerOffer_min { get; set; } = 7;
   public int Stack_max { get; set; } = 600;
   public int PerOffer_max { get; set; } = 30;
   public int Eurooffers { get; set; } = 8;
   public int Dollaroffers { get; set; } = 14;
   public int Roubleoffers { get; set; } = 78;
   public int NonStack_min { get; set; } = 1;
   public int Time_min { get; set; } = 6;
   public double Price_min { get; set; } = 0.8;
   public int NonStack_max { get; set; } = 10;
   public int Time_max { get; set; } = 60;
   public double Price_max { get; set; } = 1.4;
  }

  public class Exfils
  {
   public int CarSandbox { get; set; } = 5000;
   public int CarShoreline { get; set; } = 5000;
   public int CoopPaidSandbox { get; set; } = 5000;
   public int CoopPaidShoreline { get; set; } = 5000;
   public int CoopPaidStreets { get; set; } = 5000;
   public int CoopPaidLighthouse { get; set; } = 5000;
   public int CarLighthouse { get; set; } = 5000;
   public int CarExtractTime { get; set; } = 60;
   public bool ArmorExtract { get; set; }
   public bool CoopPaid { get; set; }
   public bool FenceGift { get; set; }
   public int CoopPaidInterchange { get; set; } = 5000;
   public int CoopPaidWoods { get; set; } = 5000;
   public int CoopPaidReserve { get; set; } = 5000;
   public bool NoBackpack { get; set; }
   public bool FreeCoop { get; set; }
   public int CarInterchange { get; set; } = 5000;
   public int CarWoods { get; set; } = 5000;
   public int CarStreets { get; set; } = 5000;
   public int CarCustoms { get; set; } = 5000;
   public bool ExtendedExtracts { get; set; }
   public bool ChanceExtracts { get; set; }
   public bool GearExtract { get; set; }
  }

  public class Fence
  {
   public bool EnableFence { get; set; }
   public int ArmorDurability_Max { get; set; } = 60;
   public int GunDurability_Max { get; set; } = 60;
   public int ArmorDurability_Min { get; set; } = 35;
   public int GunDurability_Min { get; set; } = 35;
   public double PriceMult { get; set; } = 1.2;
   public int PremiumAmountOnSale { get; set; } = 50;
   public int PresetCount { get; set; } = 5;
   public int StockTime_Min { get; set; } = 50;
   public int StockTime_Max { get; set; } = 150;
   public int AmountOnSale { get; set; } = 140;
   public double PresetMult { get; set; } = 2;
   public string Blacklist { get; set; } = "";

  }

  public class FleaConditions
  {
   public int FleaFood_Min { get; set; } = 5;
   public int FleaArmor_Min { get; set; } = 5;
   public int FleaFood_Max { get; set; } = 100;
   public int FleaArmor_Max { get; set; } = 100;
   public int FleaMedical_Min { get; set; } = 60;
   public int FleaSpec_Min { get; set; } = 2;
   public int FleaMedical_Max { get; set; } = 100;
   public int FleaSpec_Max { get; set; } = 100;
   public int FleaWeapons_Min { get; set; } = 60;
   public int FleaVests_Min { get; set; } = 5;
   public int FleaKeys_Min { get; set; } = 97;
   public int FleaWeapons_Max { get; set; } = 100;
   public int FleaVests_Max { get; set; } = 100;
   public int FleaKeys_Max { get; set; } = 100;
  }

  public class Fleamarket
  {
   public bool EnableFleaConditions { get; set; }
   public bool EnablePlayerOffers { get; set; }
   public bool FleaFIR { get; set; }
   public bool FleaNoFIRSell { get; set; }
   public bool EventOffers { get; set; }
   public int SellOffersAmount { get; set; } = 10;
   public FleaConditions FleaConditions { get; set; }
   public bool OverrideOffers { get; set; }
   public int FleaMarketLevel { get; set; } = 15;
   public List<object> FleaBlacklist { get; set; }
   //public TraderStaticOffers TraderStaticOffers { get; set; }
   public bool DisableBSGList { get; set; }
   public bool EnableFleamarket { get; set; }
   public double Sell_mult { get; set; } = 1.24;
   public int Tradeoffer_max { get; set; } = 1;
   public double Rep_loss { get; set; } = 0.03;
   public double Rep_gain { get; set; } = 0.02;
   public int Tradeoffer_min { get; set; } = 0;
   public int Sell_chance { get; set; } = 50;
   public bool EnableFees { get; set; } = true;
   public DynamicOffers DynamicOffers { get; set; }

   public Fleamarket()
   {
    FleaConditions = new FleaConditions();
    DynamicOffers = new DynamicOffers();
   }
  }

  public class Health
  {
   public int LeftArm { get; set; }
   public int RightArm { get; set; }
   public int Head { get; set; }
   public int Chest { get; set; }
   public int Stomach { get; set; }
   public int LeftLeg { get; set; }
   public int RightLeg { get; set; }
  }

  public class Hideout
  {
   public bool EnableStash { get; set; }
   public Stash Stash { get; set; }
   public Regeneration Regeneration { get; set; }
   public int WaterFilterTime { get; set; } = 325;
   public int BitcoinTime { get; set; } = 2416;
   public int MaxBitcoins { get; set; } = 3;
   public double NoFuelMult { get; set; } = 1;
   public double ScavCasePrice { get; set; } = 1;
   public double ScavCaseTime { get; set; } = 1;
   public double HideoutConstMult { get; set; } = 1;
   public double HideoutProdMult { get; set; } = 1;
   public double WaterFilterRate { get; set; } = 66;
   public double GPUBoostRate { get; set; } = 1;
   public double AirFilterRate { get; set; } = 1;
   public bool RemoveConstructionsRequirements { get; set; }
   public bool RemoveSkillRequirements { get; set; }
   public bool RemoveTraderLevelRequirements { get; set; }
   public bool EnableHideout { get; set; }
   public double FuelConsumptionRate { get; set; } = 1;

   public Hideout()
   {
    Stash = new Stash();
    Regeneration = new Regeneration();
   }
  }

  public class Services
  {
   public RepairBox RepairBox { get; set; }
   public bool EnableHealMarkup { get; set; }
   public bool EnableInsurance { get; set; }
   public bool EnableTimeOverride { get; set; }
   public int FreeHealLvl { get; set; } = 5;
   public int FreeHealRaids { get; set; } = 30;
   public int ReturnChancePrapor { get; set; } = 85;
   public int ReturnChanceTherapist { get; set; } = 95;
   public int InsuranceInterval { get; set; } = 600;
   public int InsuranceTimeOverride { get; set; } = 30;
   public int InsuranceAttachmentChance { get; set; } = 10;
   public int TherapistStorageTime { get; set; } = 144;
   public int PraporStorageTime { get; set; } = 96;
   public int Prapor_Max { get; set; } = 36;
   public int Prapor_Min { get; set; } = 24;
   public int Therapist_Max { get; set; } = 24;
   public int Therapist_Min { get; set; } = 12;
   public double TherapistLvl1 { get; set; } = 1;
   public double TherapistLvl2 { get; set; } = 1.1;
   public double TherapistLvl3 { get; set; } = 1.2;
   public double TherapistLvl4 { get; set; } = 1.35;
   public double InsuranceMultTherapistLvl1 { get; set; } = 20;
   public double InsuranceMultTherapistLvl2 { get; set; } = 21;
   public double InsuranceMultTherapistLvl3 { get; set; } = 22;
   public double InsuranceMultTherapistLvl4 { get; set; } = 23;
   public double InsuranceMultPraporLvl1 { get; set; } = 16;
   public double InsuranceMultPraporLvl2 { get; set; } = 17;
   public double InsuranceMultPraporLvl3 { get; set; } = 18;
   public double InsuranceMultPraporLvl4 { get; set; } = 19;

   public bool EnableServices { get; set; }
   public bool EnableRepair{ get; set; }
   public bool ClothesAnySide { get; set; }
   public bool ClothesLevelUnlock { get; set; }
   public bool ClothesFree { get; set; }
   public Services()
   {
    RepairBox = new RepairBox();
   }
  }

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
   public int RubStack { get; set; } = 500000;
   public int DollarStack { get; set; } = 50000;
   public int GPStack { get; set; } = 20;
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

  public class Locations
  {
   public LootOnLocations Streets { get; set; }
   public LootOnLocations Sandbox { get; set; }
   public LootOnLocations SandboxHard { get; set; }
   public LootOnLocations Lighthouse { get; set; }
   public LootOnLocations Bigmap { get; set; }
   public LootOnLocations Interchange { get; set; }
   public LootOnLocations FactoryDay { get; set; }
   public LootOnLocations Laboratory { get; set; }
   public LootOnLocations Shoreline { get; set; }
   public LootOnLocations Reserve { get; set; }
   public LootOnLocations Woods { get; set; }
   public LootOnLocations FactoryNight { get; set; }
   public bool AllContainers { get; set; }
   public Locations()
   {
    Streets = new LootOnLocations()
    {
     Loose = 3,
     Container = 1
    };
    Sandbox = new LootOnLocations()
    {
     Loose = 2.8,
     Container = 1
    };
    SandboxHard = new LootOnLocations()
    {
     Loose = 2.8,
     Container = 1
    };
    Lighthouse = new LootOnLocations()
    {
     Loose = 2.8,
     Container = 1
    };
    Bigmap = new LootOnLocations()
    {
     Loose = 2.5,
     Container = 1
    };
    Interchange = new LootOnLocations()
    {
     Loose = 2.8,
     Container = 1
    };
    FactoryDay = new LootOnLocations()
    {
     Loose = 3.5,
     Container = 1
    };
    Laboratory = new LootOnLocations()
    {
     Loose = 2.8,
     Container = 1
    };
    Shoreline = new LootOnLocations()
    {
     Loose = 3.7,
     Container = 1
    };
    Reserve = new LootOnLocations()
    {
     Loose = 2.9,
     Container = 1
    };
    Woods = new LootOnLocations()
    {
     Loose = 1.9,
     Container = 1
    };
    FactoryNight = new LootOnLocations()
    {
     Loose = 3.5,
     Container = 1
    };
   }
  }
  public class LootOnLocations
  {
   public double Loose { get; set; }
   public double Container { get; set; }

  }
   public class Loot
  {
   public Airdrops Airdrops { get; set; }
   public bool EnableLoot { get; set; }
   public Locations Locations { get; set; }

   public Loot()
   {
    Airdrops = new Airdrops();
    Locations = new Locations();
   }
  }
  public class Stats
  {
   public int MaxHydration { get; set; } = 100;
   public int MaxEnergy { get; set; } = 100;
  }
  public class Player
  {
   public bool EnableFatigue { get; set; }
   public Stats PMCStats { get; set; }
   public CharXP CharXP { get; set; }
   public RaidMult RaidMult { get; set; }
   public bool EnableStats { get; set; }
   public Skills Skills { get; set; }
   public bool FallDamage { get; set; }
   public double BlackStomach { get; set; } = 5;
   public double HydrationLoss { get; set; } = 1;
   public double EnergyLoss { get; set; } = 1;
   public bool EnableHealth { get; set; }
   public double SkillProgMult { get; set; } = 0.4;
   public Health Health { get; set; }
   public double WeaponSkillMult { get; set; } = 1;
   public bool EnablePlayer { get; set; }
   public DiedHealth DiedHealth { get; set; }
   public int MaxStamina { get; set; } = 100;
   public bool UnlimitedStamina { get; set; }

   //public Stats()
   //{ 
   // MaxEnergy = 100,
   //  MaxStamina = 100
   //}
   public Player()
   {
    PMCStats = new Stats(); 
    CharXP = new CharXP();
    RaidMult = new RaidMult();
    Skills = new Skills();
    Health = new Health()
    {
     Head = 35,
     Chest = 85,
     Stomach = 70,
     LeftArm = 60,
     LeftLeg = 65,
     RightArm = 60,
     RightLeg = 65
    };
    DiedHealth = new DiedHealth();
   }
  }



  public class PMCChance
  {
   public int PMCNamePrefix { get; set; } = 15;
   public int PMCAllNamePrefix { get; set; } = 5;
   public int PMCLooseWep { get; set; } = 15;
   public int HostilePMC { get; set; } = 80;
   public int PMCWepEnhance { get; set; } = 5;
  }

  public class Pockets
  {
   public bool SpecGKeychain { get; set; }
   public bool SpecSimpleWallet { get; set; }
   public bool SpecWZWallet { get; set; }
   public bool SpecKeycardHolder { get; set; }
   public bool SpecKeytool { get; set; }
   public bool SpecInjectorCase { get; set; }
   public int SpecSlots { get; set; } = 3;
   public int FourthH { get; set; } = 1;
   public int FourthV { get; set; } = 1;
   public int ThirdH { get; set; } = 1;
   public int ThirdV { get; set; } = 1;
   public int SecondH { get; set; } = 1;
   public int SecondV { get; set; } = 1;
   public int FirstH { get; set; } = 1;
   public int FirstV { get; set; } = 1;
  }

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
     Types = 0,
     Levels = "1,10,20,30,40,50,60",
     Experience = "1000,2000,8000,13000,19000,24000,30000",
     Reputation = "0.01,0.01,0.02,0.02,0.03,0.03,0.03",
     ItemsReward = "2,4,5,5,5,5,5",
     Roubles = "11000,20000,32000,45000,58000,70000,82000",
     GPcoins= "3,3,6,6,8,8,10",
     SkillChance= "0,0.01,0.05,0.1,0.1,0.15,0.15",
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
     Types = 0,
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

  public class RaidEvents
  {
   public bool DisableEvents { get; set; }
   public int KillaFactoryChance { get; set; } = 100;
   public int GoonsFactoryChance { get; set; } = 100;
   public bool GoonsFactory { get; set; }
   public bool BossesOnCustoms { get; set; }
   public bool BossesOnHealthResort { get; set; }
   public bool TagillaInterchange { get; set; }
   public bool HealthResortIncludeGuards { get; set; }
   public int HoundsWoods { get; set; } = 5;
   public int HoundsCustoms { get; set; } = 5;
   public int SkierFighters { get; set; } = 4;
   public int PeaceFighters { get; set; } = 15;
   public bool Christmas { get; set; }
   public bool Halloween { get; set; }
   public bool DisableZombies { get; set; }
   public bool RandomInfectionLevel { get; set; }
   public bool IncludeStreetBosses { get; set; }
   public bool KillaFactory { get; set; }
   public bool BossesOnReserve { get; set; }
   public bool RaidersEverywhere { get; set; }
   public bool GlukharLabs { get; set; }
  }

  public class RaidMult
  {
   public double MIA { get; set; } = 1;
   public double Runner { get; set; } = 0.5;
   public double Survived { get; set; } = 1.3;
   public double Killed { get; set; } = 1;
  }

  public class Raids
  {
   public int SandboxAccessLevel { get; set; } = 20;
   public int RaidTime { get; set; } = 0;
   public bool SaveQuestItems { get; set; }
   public Exfils Exfils { get; set; }
   public bool NoRunThrough { get; set; }
   public int Timeacceleration { get; set; } = 7;
   public bool SafeExit { get; set; }
   public bool SaveGearAfterDeath { get; set; }
   public RaidEvents RaidEvents { get; set; }
   public bool LabInsurance { get; set; }
   public bool EnableRaids { get; set; }
   public bool Removelabkey { get; set; }

   public bool EnableCarCoop { get; set; }
   public bool ForceBTRFriendly { get; set; }

   public bool ForceBTRStash { get; set; }
   public bool EnableBTR { get; set; }
   public int BTRCoverPrice { get; set; } = 30000;
   public int BTRTaxiPrice { get; set; } = 7000;
   public double UsecMult { get; set; } = 1.5;
   public double BearMult { get; set; } = 1;
   public double ScavMult { get; set; } = 0.8;
   public int BTRHeight { get; set; } = 2;
   public int BTRHWidth { get; set; } = 5;
   public int Season { get; set; } = 0;
   public bool ForceSeason { get; set; }
   public RaidStartup RaidStartup { get; set; }
   public Raids()
   {
    Exfils = new Exfils();
    RaidEvents = new RaidEvents();
    RaidStartup = new RaidStartup();
   }
  }

  public class RaidStartup
  {
   public bool EnableRaidStartup { get; set; }
   public int TimeBeforeDeployLocal { get; set; } = 10;
   public int AIAmount { get; set; } = 0;
   public bool SaveLoot { get; set; } = true;
   public int AIDifficulty { get; set; } = 0;
   public bool MIAEndofRaid { get; set; } = true;
   public bool TaggedAndCursed { get; set; }
   public bool EnableBosses { get; set; } = true;
   public bool ScavWars { get; set; }
  }

  public class Regeneration
  {
   public bool OfflineRegen { get; set; }
   public double HealthRegen { get; set; } = 1;
   public bool HideoutHealth { get; set; }
   public bool HideoutEnergy { get; set; }
   public bool HideoutHydration { get; set; }
   public double HydrationRegen { get; set; } = 1;
   public double EnergyRegen { get; set; } = 1;
  }

  public class RepairBox
  {
   public bool NoRandomRepair { get; set; }
   public bool OpGunRepair { get; set; }
   public double ArmorSkillMult { get; set; } = 0.05;
   public double WeaponMaintenanceSkillMult { get; set; } = 0.6;
   public double IntellectSkillMultWeaponKit { get; set; } = 0.045;
   public double IntellectSkillMultArmorKit { get; set; } = 0.03;
   public double IntellectSkillLimitTraders { get; set; } = 0.6;
   public double IntellectSkillLimitKit { get; set; } = 0.6;
   public bool OpArmorRepair { get; set; }
   public double RepairMult { get; set; } = 1;
  }

  public class Scav
  {
   public SCAVPockets SCAVPockets { get; set; }
   public bool HostileBosses { get; set; }
   public bool FriendlyBosses { get; set; }
   public double CarBaseStanding { get; set; } = 0.25;
   public int ScavTimer { get; set; } = 900;
   public bool ScavCustomPockets { get; set; }
   public bool ScavLab { get; set; }
   public bool FriendlyScavs { get; set; }
   public bool HostileScavs { get; set; }
   public double StandingFriendlyKill { get; set; } = -0.04;
   public double StandingPMCKill { get; set; } = 0.01;
   public Health Health { get; set; }
   public bool EnableScavHealth { get; set; }
   public bool EnableScav { get; set; }
   public Stats ScavStats { get; set; }
   public bool EnableStats { get; set; }
   public Scav()
   {
    SCAVPockets = new SCAVPockets();
    Health = new Health()
    {
     Head = 35,
     Chest = 85,
     Stomach = 70,
     LeftArm = 60,
     LeftLeg = 65,
     RightArm = 60,
     RightLeg = 65
    };
    ScavStats = new Stats();
   }
  }

  public class SCAVPockets
  {
   public int FourthH { get; set; } = 1;
   public int FourthV { get; set; } = 1;
   public int ThirdH { get; set; } = 1;
   public int ThirdV { get; set; } = 1;
   public int SecondH { get; set; } = 1;
   public int SecondV { get; set; } = 1;
   public int FirstH { get; set; } = 1;
   public int FirstV { get; set; } = 1;
  }

  public class ScavQuests
  {
   public int MinKillsLR2 { get; set; } = 3;
   public int MaxKillsLR2 { get; set; } = 15;
   public int MinItems { get; set; } = 2;
   public int MaxItems { get; set; } = 5;
   public int Extracts { get; set; } = 3;
   public int Types { get; set; } = 0;
   public double Spread { get; set; } = 0.5;
   public int MinKillsLR1 { get; set; } = 1;
   public int MaxKillsLR1 { get; set; } = 3;
   public int Access { get; set; } = 1;
   public int QuestAmount { get; set; } = 1;
   public int Lifespan { get; set; } = 1440;
   public string Levels { get; set; } = "1,10,20,30,40,50,60";
   public string Experience { get; set; } = "0,0,0,0,0,0,0";
   public string ItemsReward { get; set; } = "2,3,3,3,3,4,4";
   public string Reputation { get; set; } = "0.02,0.02,0.03,0.03,0.04,0.04,0.05]";
   public string SkillPoint { get; set; } = "10,15,20,25,30,35,40";
   public string SkillChance { get; set; } = "0,0,0,0,0,0,0";
   public string Roubles { get; set; } = "11000,20000,32000,45000,58000,70000,82000";
   public string GPcoins { get; set; } = "1,1,2,2,4,4,5";
  }

  public class SecureContainers
  {
   public int KappaWidth { get; set; } = 3;
   public int AlphaHeight { get; set; } = 2;
   public int KappaHeight { get; set; } = 4;
   public int AlphaWidth { get; set; } = 2;
   public int GammaWidth { get; set; } = 3;
   public int GammaHeight { get; set; } = 3;
   public int GammaTUEWidth { get; set; } = 3;
   public int GammaTUEHeight { get; set; } = 3;
   public int BetaHeight { get; set; } = 2;
   public int BetaWidth { get; set; } = 3;
   public int EpsilonWidth { get; set; } = 4;
   public int EpsilonHeight { get; set; } = 2;
   public int DevHeight { get; set; } = 3;
   public int DevWidth { get; set; } = 3;
   public int WaistPouchWidth { get; set; } = 2;
   public int WaistPouchHeight { get; set; } = 2;
  }
  public class Skills
  {
   public int SkillFatigueReset { get; set; } = 200;
   public double SkillFreshEffect { get; set; } = 1.3;
   public int SkillFPoints { get; set; } = 1;
   public int SkillPointsBeforeFatigue { get; set; } = 1;
   public double SkillMinEffect { get; set; } = 0.0001;
   public double SkillFatiguePerPoint { get; set; } = 0.6;
  }

  public class Stash
  {
   public int StashTUE { get; set; } = 72;
   public int StashLvl4 { get; set; } = 68;
   public int StashLvl3 { get; set; } = 48;
   public int StashLvl2 { get; set; } = 38;
   public int StashLvl1 { get; set; } = 28;
  }

  public class TraderMarkup
  {
   public int Ragman { get; set; } = 62;
   public int Peacekeeper { get; set; } = 45;
   public int Fence { get; set; } = 40;
   public int Prapor { get; set; } = 50;
   public int Jaeger { get; set; } = 60;
   public int Mechanic { get; set; } = 56;
   public int Skier { get; set; } = 49;
   public int Therapist { get; set; } = 63;
  }
  public class TraderSell
  {
   public double Ragman { get; set; } = 1;
   public double Peacekeeper { get; set; } = 1;
   public double Prapor { get; set; } = 1;
   public double Jaeger { get; set; } = 1;
   public double Mechanic { get; set; } = 1;
   public double Skier { get; set; } = 1;
   public double Therapist { get; set; } = 1;
  }
  public class Traders
  {
   public Fence Fence { get; set; }
   public bool RemoveTradeLimits { get; set; }
   public int QuestRedeemTime { get; set; } = 48;
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
}
