
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace VKTok.Servises
{
    class SingletonManeger
    {
        public static Frame MainFrame;
        public static Dictionary<string, string> AuthKeys = new Dictionary<string, string>();
    }
}
