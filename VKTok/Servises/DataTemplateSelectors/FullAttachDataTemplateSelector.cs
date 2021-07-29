using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTok.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VKTok.Servises.DataTemplateSelectors
{
    class FullAttachDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Image { get; set; }
        public DataTemplate Video { get; set; }
        public DataTemplate Doc { get; set; }
        public DataTemplate Pool { get; set; }
        public DataTemplate Link { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            return Get(item);
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject dependency)
        {
            return Get(item);
        }
        private DataTemplate Get(object item)
        {
            if (item is AttachPhoto)
                return Image;
            if (item is AttachVideo)
                return Video;
            if (item is AttachDoc)
                return Doc;
            if (item is AttachPool)
                return Pool;
            if (item is AttachLink)
                return Link;


            return Image;
        }
    }
}
