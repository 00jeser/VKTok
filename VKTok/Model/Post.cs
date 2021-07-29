using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VKTok.Servises;

namespace VKTok.Model
{
    public class Attach : INotifyPropertyChanged
    {
        public virtual string URL { get; set; }
        //-----------------------------------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class AttachPhoto : Attach
    {
        public string SmallURL { get; set; }
        public string LargueURL { get; set; }
        public override string URL { get => LargueURL; set => LargueURL = value; }
    }
    public class AttachVideo : Attach
    {
        public string PreviewURL { get; set; }
        public string VideoURL { get; set; }
        public override string URL { get => PreviewURL; set => PreviewURL = value; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int id { get; set; }
        public int OvnerId { get; set; }
        public string Title { get; set; }
        public string TrackCode { get; set; }
        public string Description { get; set; }
        public string AccessKey { get; set; }
    }
    public class AttachLink : Attach
    {
        public string LinkURL { get; set; }
        public override string URL { get => LinkURL; set => LinkURL = value; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string photoURL { get; set; }
    }
    public class AttachDoc : Attach
    {
        public string DocURL { get; set; }
        public override string URL { get => DocURL; set => DocURL = value; }
        public string Preview { get; set; }
        public string Title { get; set; }
        public string Ext { get; set; }
    }
    public class AttachPool : Attach
    {
        // TODO : AttachPool
    }


    public class Author
    {
        public string Name { get; set; }
        public string IconURL { get; set; }
        public int id { get; set; }
    }
    class Post : INotifyPropertyChanged
    {

        public DateTime Date { get; set; }
        public Author PostAuthor { get; set; }
        public int PostId { get; set; }
        public string PostMessage { get; set; }
        public ObservableCollection<Attach> Attaches { get; set; }

        public Attach SelectedAttached
        {
            get => null;
            set
            {
                if (value != null)
                {
                    SingletonManeger.OpenImage(Attaches, value);
                    SelectedAttached = null;
                }
                else
                    OnPropertyChanged("SelectedAttached");
            }
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
