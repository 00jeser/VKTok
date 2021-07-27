using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VKTok
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VKOAuth2 : Page
    {
        public VKOAuth2()
        {
            this.InitializeComponent();
            wv.Navigate(new Uri($"https://oauth.vk.com/authorize?client_id=7911996&display=page&redirect_uri=http://oauth.vk.com/callback&scope={(1 << 1) + (1 << 13) + (1 << 4)}&response_type=token&v=5.131&state=123456"));
        }

        private void wv_WebResourceRequested(WebView sender, WebViewWebResourceRequestedEventArgs args)
        {
            //https://oauth.vk.com/blank.html#access_token=9af0e7ebadad36011720f8f2180549e47ab9f93b84bf57023ff73459c3ef29c347d270c6a455251ade07c&expires_in=86400&user_id=271799657&state=123456
            if (args.Request.RequestUri.AbsoluteUri.StartsWith("https://oauth.vk.com/blank.html"))
            {
                Dictionary<string, string> keys = new Dictionary<string, string>();
                //var token = args.Request.RequestUri.AbsoluteUri.Split("access_token=")[1].Split("&expires_in")[0];
                foreach(string k in args.Request.RequestUri.AbsoluteUri.Split("#")[1].Split("&")) 
                {
                    keys.Add(k.Split("=")[0], k.Split("=")[1]);
                    SingletonManeger.AuthKeys = keys;
                }
            }
        }
    }
}
