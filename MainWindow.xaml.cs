﻿using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Greed
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
  public MainWindow()
  {
   string ModFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
   //ToolTipService.ShowDurationProperty = 8000;
   System.Windows.Media.RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
   ToolTipService.ShowDurationProperty.OverrideMetadata(typeof(DependencyObject), new FrameworkPropertyMetadata(Int32.MaxValue));
   InitializeComponent();
   LangSwitch((Thread.CurrentThread.CurrentCulture).ToString());

   if (!ModFolder.Contains("mods") && !ModFolder.Contains("Mods"))//&& !ModFolder.Contains("bin"))
   {
    Popup Message = new((string)Application.Current.FindResource("SVMWrongInstallation"));
    //Popup Message = new((string)("Same Name Selected, want to override?"));
    Message.ShowDialog();
    if (!Message.Confirm)
    {
     this.Close();
    }
   }
   if (!Directory.GetCurrentDirectory().Contains("Loader"))
   {
    System.IO.Directory.CreateDirectory("Loader");
   }
   if (!Directory.GetCurrentDirectory().Contains("Presets"))
   {
    System.IO.Directory.CreateDirectory("Presets");
   }

   ToList();
   MainClass.MainConfig mainConfig = new();
   DataContext = mainConfig;
  }

  private void LangSwitchClick(object sender, RoutedEventArgs e)
  {
   LangSwitch(((MenuItem)sender).Tag.ToString());
  }
  private static void LoadRTF(RichTextBox RT, Stream Stream)
  {
   RT.Document.Blocks.Clear();
   RT.Selection.Load(Stream, DataFormats.Rtf);
   RT.Selection.Select(RT.Selection.Start, RT.Selection.Start);
  }
  private void ToList()
  {
   string startFolder = Directory.GetCurrentDirectory() + @"\Presets";
   object tempfield = Presets.SelectedItem;
   Presets.Items.Clear();
   System.IO.DirectoryInfo dir = new(startFolder);
   IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
   IEnumerable<System.IO.FileInfo> fileQuery =
       from file in fileList
       where file.Extension == ".json"
       orderby file.Name
       select file;
   foreach (System.IO.FileInfo fi in fileQuery)
   {
    Presets.Items.Add(fi.Name.Remove(fi.Name.Length - 5));
   }
   Presets.SelectedItem = tempfield;
  }

  private void LangSwitch(string lang)
  {
   Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
   Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
   //Application.Current.Resources.MergedDictionaries.Clear();
   switch (lang)
   {
    case "ru-RU":
    case "ru-UA":
     LoadLanguage($"/Resources/Dictionary-ru-RU.xaml", "Greed.Resources.HelloRU.rtf", "Greed.Resources.faqRU.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_bear.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthRU.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthRU.png"));
     break;
    case "ko-KR":
     LoadLanguage($"/Resources/Dictionary-ko-KR.xaml", "Greed.Resources.HelloKR.rtf", "Greed.Resources.faqKR.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_usec.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthKO.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthKO.png"));
     break;
    case "uk-UA":
     LoadLanguage($"/Resources/Dictionary-uk-UA.xaml", "Greed.Resources.HelloUA.rtf", "Greed.Resources.faqUA.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_bear.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthUA.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthUA.png"));
     break;
    case "zh-CHS":
    case "zh-CN":
     LoadLanguage($"/Resources/Dictionary-zh-CN.xaml", "Greed.Resources.HelloCN.rtf", "Greed.Resources.faqCN.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_bear.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthCN.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthCN.png"));
     break;
    case "es-ES":
     LoadLanguage($"/Resources/Dictionary-es-ES.xaml", "Greed.Resources.HelloES.rtf", "Greed.Resources.faqES.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_usec.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthEN.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthEN.png"));
     break;
    default:
     LoadLanguage($"/Resources/Dictionary-en-US.xaml", "Greed.Resources.HelloEN.rtf", "Greed.Resources.faqEN.rtf");
     PMCIcon.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Icons/icon_usec.png"));
     PMCHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthEN.png"));
     SCAVHealth.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/HealthEN.png"));
     break;
   }
  }
  private void LoadLanguage(string dict, string hello, string faq)
  {
   ResourceDictionary resdict = new()
   {
    Source = new Uri(dict, UriKind.Relative)
   };
   Application.Current.Resources.MergedDictionaries.Add(resdict);
   CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
   customCulture.NumberFormat.NumberDecimalSeparator = ".";
   System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
   LoadRTF(WelcomeMessage, Assembly.GetExecutingAssembly().GetManifestResourceStream(hello));
   LoadRTF(RTF1, Assembly.GetExecutingAssembly().GetManifestResourceStream(faq));
  }

  private void SavePreset(object sender, RoutedEventArgs e)
  {
   try
   {
    if (Presets.Text == "null" || Presets.Text == "Null")
    {
     Popup Message = new((string)Application.Current.FindResource("PresetNamedNullError"));
     Message.ShowDialog();
    }
    else
    {
     if (CheckName())
     {
      string rawJSON = JsonSerializer.Serialize((MainClass.MainConfig)DataContext, new JsonSerializerOptions() { WriteIndented = true });
      string savepath = Directory.GetCurrentDirectory() + @"\Presets\";
      savepath += (Presets.Text == "") ? "Noname.json" : Presets.Text + ".json";
      File.WriteAllText(savepath, rawJSON);
      ToList();
      if (Presets.Text == "")
      {
       Presets.Text = "Noname";
      }
      _ = SaveTextAsync();
     }
    }
   }
   catch
   {
    Popup Message = new((string)Application.Current.FindResource("ApplyFailedUnknown"));
    Message.ShowDialog();
   }
  }

  private bool CheckName()
  {
   string savepath = Directory.GetCurrentDirectory() + @"\Presets\";
   if (File.Exists(savepath + Presets.Text + ".json"))
   {
    Popup Message = new((string)Application.Current.FindResource("OverridePreset"));
    Message.ShowDialog();
    return Message.Confirm;
   }
   else if (!Presets.Text.Contains('/') && !Presets.Text.Contains('\\') && !Presets.Text.Contains('"') && !Presets.Text.Contains(':') && !Presets.Text.Contains('?') && !Presets.Text.Contains('>') && !Presets.Text.Contains('<') && !Presets.Text.Contains('|')) //!Presets.Text.Contains(" ")
   {
    return true;
   }
   else
   {
    Popup Message = new((string)Application.Current.FindResource("PresetNameFail"));
    Message.ShowDialog();
    return false;
   }
  }

  private void LoadPreset(object sender, RoutedEventArgs e)
  {
   if (Presets.Text == "")
   {
    if (File.Exists(Directory.GetCurrentDirectory() + @"\Presets\Noname.json"))
    {
     Presets.Text = "Noname";
     Popup Message = new((string)Application.Current.FindResource("NonameLoaded"));
     Message.ShowDialog();
     LoadFunc();
     _ = LoadTextAsync();
    }
    else
    {
     Popup Message = new((string)Application.Current.FindResource("NothingToLoad"));
     Message.ShowDialog();
    }
   }
   else
   {
    LoadFunc();
    _ = LoadTextAsync();
   }
  }

  private void LoadJson()
  {
   string rawJSON = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Presets\" + Presets.Text + ".json");
   MainClass.MainConfig loadedConfig = JsonSerializer.Deserialize<MainClass.MainConfig>(rawJSON);
   DataContext = loadedConfig;
  }
  private void LoadFunc()
  {
   try
   {
    LoadJson();//Horrible solution - the issue is: Converters and MVVM maximum/minimums bugging out the parsed values, therefore to properly apply them - i need to reload DataContext twice.
    LoadJson();//Possible solution was nulling DataContext, however it cause application to hang for 3-5 seconds, unacceptable. Previous solution was loading whole LoadFunc, causing messages to show up twice.
    //May coding dieties mercy me
    SectionEnabled(null, null);
   }
   catch (FileNotFoundException)
   {
    Popup Message = new((string)Application.Current.FindResource("FileNotFoundException"));
    Message.ShowDialog();
   }
   catch (System.Text.Json.JsonException e)
   {
    Popup Message = new((string)Application.Current.FindResource("CorruptedJSON") + "\n" + e.Message);
    Message.ShowDialog();
   }
   catch (AccessViolationException)
   {
    Popup Message = new((string)Application.Current.FindResource("NoAccess"));
    Message.ShowDialog();
   }
   catch
   {
    Popup Message = new((string)Application.Current.FindResource("ApplyFailedUnknown"));
    Message.ShowDialog();
   }
  }
  private void RunEverything(object sender, RoutedEventArgs e)
  {
   try
   {
    string modFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
    string exeFolder = Path.GetFullPath(Path.Combine(modFolder, "..", ".."));

    Process serverProcess = new()
    {

     StartInfo = new ProcessStartInfo
     {
      FileName = exeFolder + @"\SPT.Server.exe",
      WorkingDirectory = exeFolder
     }
    };
    serverProcess.Start();
    Process launcherprocess = new()
    {

     StartInfo = new ProcessStartInfo
     {
      FileName = exeFolder + @"\SPT.Launcher.exe",
      WorkingDirectory = exeFolder
     }
    };
    launcherprocess.Start();
   }
   catch (Exception)
   {
    Popup Message = new((string)Application.Current.FindResource("RunFailed"));
    Message.ShowDialog();
   }
  }

  private void CloseEverything(object sender, RoutedEventArgs e)
  {
   string modFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
   string exeFolder = Path.GetFullPath(Path.Combine(modFolder, "..", ".."));
   Process[] serverProcesses = Process.GetProcessesByName("SPT.Server");
   {
    foreach (Process process in serverProcesses)
    {
     if (process.MainModule.FileName == exeFolder + @"\SPT.Server.exe")
      process.Kill();
    }
   }
   Process[] launcherProcesses = Process.GetProcessesByName("SPT.launcher");
   {
    foreach (Process process in launcherProcesses)
    {
     if (process.MainModule.FileName == exeFolder + @"\SPT.Launcher.exe")
      process.Kill();
    }
   }
  }

  private void PresetFolder(object sender, EventArgs e)
  {
   if (Directory.Exists(Directory.GetCurrentDirectory() + @"\Presets"))
   {

    System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + @"\Presets");
   }
   else
   {
    Popup Message = new((string)Application.Current.FindResource("PresetFolderDeleted"));
    Message.ShowDialog();
   }
  }
  private void Apply_Click(object sender, RoutedEventArgs e)
  {
   if (RoubleRatio.Value + DollarRatio.Value + EuroRatio.Value != 100)
   {
    Popup Message = new((string)Application.Current.FindResource("RatioError"));
    Message.ShowDialog();
    return;
   }
   try
   {
    string savepath = Directory.GetCurrentDirectory() + @"\Loader\loader.json";
    System.IO.File.Delete(savepath);
    if (Presets.Text == "")
    {
     if (File.Exists(Directory.GetCurrentDirectory() + @"\Presets\Noname.json"))
     {
      System.IO.File.AppendAllText(savepath, "{\n" + "\"CurrentlySelectedPreset\": \"Noname\"" + "\n}");
      Popup Message = new((string)Application.Current.FindResource("NonameApplied"));
      Message.ShowDialog();
     }
     else
     {
      Popup Message = new((string)Application.Current.FindResource("NothingToApply"));
      Message.ShowDialog();
     }
    }
    else
    {
     System.IO.File.AppendAllText(savepath, "{\n" + "\"CurrentlySelectedPreset\":\"" + Presets.Text + "\"\n}");
     _ = ApplyTextAsync();
    }
   }
   catch
   {
    Popup Message = new((string)Application.Current.FindResource("ApplyFailedUnknown"));
    Message.ShowDialog();
   }
  }

  private async Task ApplyTextAsync()
  {
   Apply.Text = new((string)Application.Current.FindResource("Applied"));
   await Task.Delay(1500);
   Apply.Text = new((string)Application.Current.FindResource("ApplyButton"));
  }
  private async Task LoadTextAsync()
  {
   Load.Text = new((string)Application.Current.FindResource("Loaded"));
   await Task.Delay(1500);
   Load.Text = new((string)Application.Current.FindResource("LoadButton"));
  }
  private async Task SaveTextAsync()
  {
   Save.Text = new((string)Application.Current.FindResource("Saved"));
   await Task.Delay(1500);
   Save.Text = new((string)Application.Current.FindResource("SaveButton"));
  }
  private void RunURL(string Resource, string URL)
  {
   Popup Message = new((string)Application.Current.FindResource(Resource));
   Message.ShowDialog();
   if (Message.Confirm == true)
   {
    string browserPath = ("C:/Windows/explorer.exe");
    string argUrl = "\"" + URL + "\"";
    System.Diagnostics.Process.Start(browserPath, argUrl);
   }
  }
  private void ItemFinder(object sender, EventArgs e)
  {
   Popup Message = new((string)Application.Current.FindResource("IDFinder"));
   Message.ShowDialog();
   if (Message.Confirm == true)
   {
    string browserPath = ("C:/Windows/explorer.exe");
    string argUrl = "https://db.sp-tarkov.com/search";
    System.Diagnostics.Process.Start(browserPath, argUrl);
   }
  }
  private void SPTDiscord(object sender, EventArgs e)
  {
   RunURL("SPTLink", "https://discord.gg/Xn9msqQZan");
  }
  private void SPTWEB(object sender, EventArgs e)
  {
   RunURL("SPTWeb", "https://hub.sp-tarkov.com");
  }
  private void KofiLink(object sender, EventArgs e)
  {
   RunURL("KofiLink", "https://ko-fi.com/ghostfenixx");
  }
  private void GitHubLink(object sender, EventArgs e)
  {
   RunURL("GitHubLink", "https://github.com/GhostFenixx?tab=repositories");
  }
  private void ModLink(object sender, EventArgs e)
  {
   RunURL("ModPage", "https://hub.sp-tarkov.com/files/file/379-kmc-server-value-modifier");
  }
  private void FikaDiscord(object sender, EventArgs e)
  {
   RunURL("FikaLink", "https://discord.gg/HknsaAjGvX");
  }
  private void WikiPage(object sender, EventArgs e)
  {
   RunURL("WikiPage_Link", "https://escapefromtarkov.fandom.com/wiki/Escape_from_Tarkov_Wiki");
  }
  private void InstallPlugin(object sender, RoutedEventArgs e)
  {
   string modFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
   string exeFolder = Path.GetFullPath(Path.Combine(modFolder, "..", ".."));
   string pluginFolder = (exeFolder + @"\BepInEx\plugins\");
   string pluginname = @"HideSpecialIcon.dll";
   try
   {
    if (!File.Exists(pluginFolder + pluginname))
    {
     Stream stream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Greed.Resources.HideSpecialIcon.dll");
     var fileStream = File.Create(pluginFolder + pluginname);
     stream2.CopyTo(fileStream);
     fileStream.Close();
     Popup Message = new((string)Application.Current.FindResource("InstallPluginComplete"));
     Message.ShowDialog();
    }
    else
    {
     Popup Message = new((string)Application.Current.FindResource("InstallationAlreadyDone"));
     Message.ShowDialog();
    }
   }
   catch (Exception ex)
   {
    Popup Message = new((string)Application.Current.FindResource("InstallPluginFailed") + "\n\n" + ex);
    Message.ShowDialog();
   }
  }
  private void Disclaimer(object sender, RoutedEventArgs e)
  {
   Popup Message = new((string)Application.Current.FindResource("DisclaimerText"));
   Message.ShowDialog();
  }
  private void ThanksTo(object sender, RoutedEventArgs e)
  {
   Popup Message = new((string)Application.Current.FindResource("ThanksToText"));
   Message.ShowDialog();
  }
  private void License(object sender, RoutedEventArgs e)
  {
   Popup Message = new((string)Application.Current.FindResource("LicenseText"));
   Message.ShowDialog();
  }

  private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   if (LoadLast.IsChecked)
   {
    File.WriteAllText("UIcfg", "true," + Presets.Text);
   }
  }
  private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
  {
   Regex regex = new("[`<>^@!?#%*%:&\\]*$]");
   e.Handled = regex.IsMatch(e.Text);
  }
  private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
  {
   Regex regex = new("[^0-9.,]+");
   e.Handled = regex.IsMatch(e.Text);
  }

  private void LoadLast_Click(object sender, RoutedEventArgs e)
  {
   if (LoadLast.IsChecked)
   {
    File.WriteAllText("UIcfg", "true," + Presets.Text);
   }
   else
   {
    File.WriteAllText("UIcfg", "false," + Presets.Text);
   }
  }

  private void HostilitySwitchers(object sender, RoutedEventArgs e)
  {
   if (FriendlyScav.IsChecked == true && HostileScav.IsChecked == true)
   {
    FriendlyScav.IsChecked = false;
   }
  }

  private void FriendlySwitchers(object sender, RoutedEventArgs e)
  {
   if (FriendlyScav.IsChecked == true && HostileScav.IsChecked == true)
   {
    HostileScav.IsChecked = false;
   }
  }

  private void FriendlyBossSwitchers(object sender, RoutedEventArgs e)
  {
   if (FriendlyBoss.IsChecked == true && HostileBoss.IsChecked == true)
   {
    FriendlyBoss.IsChecked = false;
   }
  }
  private void HostilityBossSwitchers(object sender, RoutedEventArgs e)
  {
   if (FriendlyBoss.IsChecked == true && HostileBoss.IsChecked == true)
   {
    HostileBoss.IsChecked = false;
   }
  }
  private void SafeExitsSwitchers(object sender, RoutedEventArgs e)
  {
   if (Softcore.IsChecked == true && SafeExits.IsChecked == true)
   {
    Softcore.IsChecked = false;
   }
  }
  private void SoftcoreSwitchers(object sender, RoutedEventArgs e)
  {
   if (SafeExits.IsChecked == true && Softcore.IsChecked == true)
   {
    SafeExits.IsChecked = false;
   }
  }

  private void ChangelogOpen(object sender, RoutedEventArgs e)
  {
   Popup Message = new((string)Application.Current.FindResource("ChangelogText"));
   Message.ShowDialog();
  }
  private void SectionEnabled(object sender, RoutedEventArgs e)//horrible
  {
   EnableSection(ItemsCheck.IsChecked, ItemsSection);
   EnableSection(HideoutCheck.IsChecked, HideoutSection);
   EnableSection(TradersCheck.IsChecked, TradersSection);
   EnableSection(ServiceCheck.IsChecked, ServicesSection);
   EnableSection(LootCheck.IsChecked, LootSection);
   EnableSection(PlayerCheck.IsChecked, PlayerSection);
   EnableSection(RaidCheck.IsChecked, RaidSection);
   EnableSection(FleaCheck.IsChecked, FleaSection);
   EnableSection(QuestsCheck.IsChecked, QuestsSection);
   EnableSection(CSMCheck.IsChecked, CSMSection);
   EnableSection(SCAVCheck.IsChecked, SCAVSection);
   EnableSection(BotsCheck.IsChecked, BotsSection);
   EnableSection(PMCCheck.IsChecked, PMCSection);
   EnableSection(CustomCheck.IsChecked, CustomSection);
   EnableSubSection(StashCheck.IsChecked, StashSection);
   EnableSubSection(PMCNameCheck.IsChecked, PMCNameSection);
   EnableSubSection(IICCheck.IsChecked, IICSection);
   EnableSubSection(PMCPocketsCheck.IsChecked, PMCPocketsSection);
   EnableSubSection(AmmoCheck.IsChecked, AmmoSection);
   EnableSubSection(QuestsMiscCheck.IsChecked, QuestsMiscSection);
   EnableSubSection(ScavPocketsCheck.IsChecked, ScavPocketsSection);
   EnableSubSection(HealthMarkupCheck.IsChecked, HealthMarkupSection);
   EnableSubSection(PMCStatsCheck.IsChecked, PMCStatsSection);
   EnableSubSection(CurrencyCheck.IsChecked, CurrencySection);
   EnableSubSection(CasesCheck.IsChecked, CasesSection);
   EnableSubSection(SecureCasesCheck.IsChecked, SecureCasesSection);
   EnableSubSection(InsuranceCheck.IsChecked, InsuranceSection);
   EnableSubSection(RepairCheck.IsChecked, RepairSection);
   EnableSubSection(PMCChancesCheck.IsChecked, PMCChancesSection);
   EnableSubSection(FatigueCheck.IsChecked, FatigueSection);
   EnableSubSection(KeysCheck.IsChecked, KeysSection);
   EnableSubSection(FenceCheck.IsChecked, FenceSection);
   EnableSubSection(BTRCheck.IsChecked, BTRSection);
   EnableSubSection(CarCoopCheck.IsChecked, CarCoopSection);
   EnableSubSection(RaidStartupCheck.IsChecked, RaidStartupSection);
   EnableSubSection(FleaConditionsCheck.IsChecked, FleaConditionsSection);
   EnableSubSection(PlayerOffersCheck.IsChecked, PlayerOffersSection);
   EnableSubSection(WeatherCheck.IsChecked, WeatherSection);
   EnableSubSection(ScavStatsCheck.IsChecked, ScavStatsSection);
   EnableSubSection(StaminaLegsCheck.IsChecked, StaminaLegsSection);
   EnableSubSection(StaminaHandsCheck.IsChecked, StaminaHandsSection);
  }
  public static void EnableSection(bool? Checker, Grid Field)
  {
   if (Checker == true)
   {
    Field.IsEnabled = true;
    Field.Opacity = 1;
   }
   else
   {
    Field.IsEnabled = false;
    Field.Opacity = 0.2;
   }
  }
  public static void EnableSubSection(bool? Checker, StackPanel Field)
  {
   if (Checker == true)
   {
    Field.IsEnabled = true;
   }
   else
   {
    Field.IsEnabled = false;
   }
  }

  private void Dragger(object sender, System.Windows.Input.MouseButtonEventArgs e)
  {
   DragMove();
  }

  private void AppMinimize(object sender, RoutedEventArgs e)
  {
   this.WindowState = WindowState.Minimized;
  }

  private void AppMaximize(object sender, RoutedEventArgs e)
  {
   if (this.WindowState == WindowState.Maximized)
   {
    this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
    this.WindowState = WindowState.Normal;
   }
   else if (this.WindowState == WindowState.Normal)
   {
    this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
    this.WindowState = WindowState.Maximized;
   }
  }

  private void AppClose(object sender, RoutedEventArgs e)
  {
   Close();
  }

  private void MainGrid_Loaded(object sender, RoutedEventArgs e)
  {
   if (File.Exists("UIcfg"))
   {
    string path = Directory.GetCurrentDirectory() + @"\UIcfg";
    string cfg = File.ReadAllText(path);
    string[] load = cfg.Split(',');
    if (load[0] == "true")
    {
     LoadLast.IsChecked = true;
     Presets.Text = load[1];
     LoadFunc();
    }
   }
  }
 }
}