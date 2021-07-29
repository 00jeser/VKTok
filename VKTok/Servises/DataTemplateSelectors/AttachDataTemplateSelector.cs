using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VKTok.Servises.DataTemplateSelectors
{
    class AttachDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Photo { get; set; }
        public DataTemplate Video { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            Application.Current.Exit();
            if (item is Model.Post.AttachPhoto)
            {
                return Photo;
            }
            else
            {
                return Video;
            }
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject dependency)
        {
            Application.Current.Exit();
            if (item is Model.Post.AttachPhoto)
            {
                return Photo;
            }
            else
            {
                return Video;
            }
        }
    }
}
