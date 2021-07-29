
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTok.Model;
using Windows.UI.Xaml.Controls;

namespace VKTok.Servises
{
    class SingletonManeger
    {
        public static Frame MainFrame;
        public static Dictionary<string, string> AuthKeys = new Dictionary<string, string>();

        public delegate void OpenImageDelegat(ObservableCollection<Attach> attaches, Attach selectedAttach);
        public static event OpenImageDelegat OpenImageEvent;
        public static void OpenImage(ObservableCollection<Attach> attaches, Attach selectedAttach) 
        {
            OpenImageEvent?.Invoke(attaches, selectedAttach);
        }
    }
}
