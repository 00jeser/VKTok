using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VKTok.Model;
using VKTok.Servises;
using Newtonsoft.Json;


namespace VKTok.ViewModel
{
    class FeedViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Post> _posts = new ObservableCollection<Post>();
        public ObservableCollection<Post> Posts
        {
            get => _posts;
            set
            {
                _posts = value;
                OnPropertyChanged(nameof(Posts));
            }
        }

        private string next = "";
        private bool CanAdd = true;

        private int _i;
        public int CurrentIndex
        {
            get => _i;
            set
            {
                _i = value;
                if (Posts.Count > 2 && CanAdd && Posts.Count - value <= 2) Add();
                OnPropertyChanged();
            }
        }
        public FeedViewModel()
        {
            Init();
        }

        private void Init()
        {
            next = "";
            Posts = new ObservableCollection<Post>();
            Add();
        }
        private async void Add()
        {
            CanAdd = false;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://api.vk.com/method/" +
                $"newsfeed.get?" +
                $"&access_token={SingletonManeger.AuthKeys["access_token"]}" +
                $"&filters=post,photo" +
                $"&start_from={next}" +
                $"&v=5.131");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JsonConvert.DeserializeObject<Root>(responseBody);
            next = root.response.next_from;
            foreach (var p in root.response.items)
            {
                Post tmp = new Post();
                tmp.PostId = p.post_id;
                tmp.Date = new DateTime(p.date);
                tmp.PostMessage = p.text;
                foreach (var a in root.response.groups)
                {
                    if (-p.source_id == a.id)
                    {
                        tmp.PostAuthor = new Post.Author()
                        {
                            Name = a.name,
                            id = a.id,
                            IconURL = a.photo_200
                        };
                    }
                }
                if (p.attachments != null && p.attachments.Count != 0)
                {
                    tmp.Attaches = new ObservableCollection<Post.Attach>();
                    foreach (var s in p.attachments)
                    {
                        if (s.type == "photo")
                        {
                            tmp.Attaches.Add(new Post.AttachPhoto());
                            int minS = int.MaxValue, maxS = 0;
                            foreach (var size in s.photo.sizes)
                            {
                                if (size.height * size.width > maxS)
                                {
                                    (tmp.Attaches.Last() as Post.AttachPhoto).LargueURL = size.url;
                                }
                                if (size.height * size.width < minS)
                                {
                                    (tmp.Attaches.Last() as Post.AttachPhoto).SmallURL = size.url;
                                }
                            }
                        }
                        if (s.type == "video")
                        {
                            var tmpv = new Post.AttachVideo()
                            {
                                AccessKey = s.video.access_key,
                                Description = s.video.description,
                                Height = s.video.height,
                                Width = s.video.width,
                                id = s.video.id,
                                OvnerId = s.video.owner_id,
                                Title = s.video.title,
                                TrackCode = s.video.track_code,
                                PreviewURL = s.video.image.OrderBy(x => x.width * x.height).Last().url,
                                VideoURL = await VideoUrlFinder.GetURLAsync(s.video.owner_id, s.video.id, s.video.access_key)
                            };
                            tmp.Attaches.Add(tmpv);
                        }
                    }
                }
                if (tmp.Attaches != null && tmp.Attaches.Count != 0 || !string.IsNullOrEmpty(tmp.PostMessage))
                    Posts.Add(tmp);
            }
            CanAdd = true;
        }


        //-----------------------------------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
