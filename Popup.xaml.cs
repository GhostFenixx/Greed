using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Greed
{
 /// <summary>
 /// Логика взаимодействия для Popup.xaml
 /// </summary>
 public partial class Popup : Window
 {
  public bool Confirm { get; private set; }
  public Popup(string value)
  {
   System.Windows.Media.RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
   InitializeComponent();
   textBlock.Text = value;
   this.button.Click += CloseWindow;
  }

  void OnCancel()
  {
   this.Confirm = false;
  }

  private void CloseWindow(object sender, RoutedEventArgs e)
  {
   this.Close();
  }

  private void OnOkay(object sender, RoutedEventArgs e)
  {
   this.Confirm = true;
  }
  private void Dragger(object sender, System.Windows.Input.MouseButtonEventArgs e)
  {
   DragMove();
  }
 }
 }