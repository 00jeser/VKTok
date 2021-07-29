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
    class PostCompositionDataTemplateSelectors : DataTemplateSelector
    {
        public DataTemplate Multicontent { get; set; }
        public DataTemplate AttachOnly { get; set; }
        public DataTemplate TextOnly { get; set; }

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
            Post post = item as Post;
            if ((post.Attaches == null || post.Attaches.Count == 0) && !string.IsNullOrEmpty(post.PostMessage))
                return TextOnly;

            return Multicontent;
        }
    }
}
