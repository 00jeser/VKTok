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
using Microsoft.Toolkit.Uwp;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VKTok.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FeedView : Page
    {
        public FeedView()
        {
            this.InitializeComponent();
            
            me.Source = new Uri("https://vk.com/video_ext.php?oid=-199152847&id=456241614&hash=b99d6e754d2bffb9&__ref=vk.api&api_hash=162738732908c2ea45bb17a01031_GI3TCNZZHE3DKNY");
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (sender as GridView).SelectedItem = null;
        }
    }
}
