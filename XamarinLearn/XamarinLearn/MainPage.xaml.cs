using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLearn
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      spTitle.Text = "PackageName：" + Xamarin.Essentials.AppInfo.PackageName + "\n";
      sp2Title.Text = "Name：" + Xamarin.Essentials.AppInfo.Name + "\n";
    }
  }
}
