using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using VKTok.Servises;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace VKTok
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            nf.Navigate(typeof(VKOAuth2));
            SingletonManeger.MainFrame = nf;
            SingletonManeger.OpenImageEvent += OpenImage;
            Navigate();
        }

        private void OpenImage(System.Collections.ObjectModel.ObservableCollection<Model.Post.Attach> attaches, Model.Post.Attach selectedAttach)
        {
            AttachGrid.Visibility = Visibility.Visible;
            Gallery.SelectedItem = null;
            Gallery.ItemsSource = null;
            while (Gallery.ItemsSource != null) { }
            Gallery.ItemsSource = attaches;
            try { Gallery.SelectedItem = selectedAttach; } catch (Exception) { }
        }

        public async void Navigate()
        {
            while (SingletonManeger.AuthKeys.Count == 0)
                await Task.Delay(200);
            nf.Navigate(typeof(View.FeedView));
            nv.SelectedItem = Sub;
        }

        private void CloseAttachGrid(object sender, RoutedEventArgs e)
        {
            AttachGrid.Visibility = Visibility.Collapsed;
            Gallery.ItemsSource = null;
        }
    }
}
