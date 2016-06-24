using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

 
namespace Alayaz.Graph.XForm.AlgoLab.UWP
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Xamarin.Forms.Platform.UWP.WindowsPage  //Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new Alayaz.Graph.XForm.AlgoLab.App());
        }
    }
}
