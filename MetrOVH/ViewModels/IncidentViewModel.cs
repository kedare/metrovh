using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MetrOVH.Resources;

namespace MetrOVH.ViewModels
{
    public class IncidentViewModel : INotifyPropertyChanged
    {
        public IncidentViewModel()
        {
            this.Items = new ObservableCollection<IncidentViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<IncidentViewModel> Items { get; private set; }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        private string _id;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        /// <returns></returns>
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }

        private string _lineOne;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineOne
        {
            get
            {
                return _lineOne;
            }
            set
            {
                if (value != _lineOne)
                {
                    _lineOne = value;
                    NotifyPropertyChanged("LineOne");
                }
            }
        }

        private string _lineTwo;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineTwo
        {
            get
            {
                return _lineTwo;
            }
            set
            {
                if (value != _lineTwo)
                {
                    _lineTwo = value;
                    NotifyPropertyChanged("LineTwo");
                }
            }
        }

        private string _rssFeed;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string RssFeed
        {
            get
            {
                return _rssFeed;
            }
            set
            {
                if (value != _rssFeed)
                {
                    _rssFeed = value;
                    NotifyPropertyChanged("RssFeed");
                }
            }
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Add(new IncidentViewModel() { ID = "1", LineOne = "Domain", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=1" });
            this.Items.Add(new IncidentViewModel() { ID = "2", LineOne = "Free Services", LineTwo = "", RssFeed="http://travaux.ovh.net/rss.php?proj=2"});
            this.Items.Add(new IncidentViewModel() { ID = "3", LineOne = "Emails", LineTwo = "", RssFeed="http://travaux.ovh.net/rss.php?proj=3"});
            this.Items.Add(new IncidentViewModel() { ID = "4", LineOne = "Shared Hosting", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=4" });
            this.Items.Add(new IncidentViewModel() { ID = "5", LineOne = "Dedicated Hosting", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=5" });
            this.Items.Add(new IncidentViewModel() { ID = "7", LineOne = "E-Backup", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=7" });
            this.Items.Add(new IncidentViewModel() { ID = "8", LineOne = "Tel2Pay", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=8" });
            this.Items.Add(new IncidentViewModel() { ID = "8", LineOne = "Network", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=9" });
            this.Items.Add(new IncidentViewModel() { ID = "10", LineOne = "Manager", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=10" });
            this.Items.Add(new IncidentViewModel() { ID = "11", LineOne = "Datacenter", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=11" });
            this.Items.Add(new IncidentViewModel() { ID = "12", LineOne = "Support", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=12" });
            this.Items.Add(new IncidentViewModel() { ID = "14", LineOne = "Demo1G", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=14" });
            this.Items.Add(new IncidentViewModel() { ID = "15", LineOne = "RPS", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=15" });
            this.Items.Add(new IncidentViewModel() { ID = "16", LineOne = "VoIP", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=16" });
            this.Items.Add(new IncidentViewModel() { ID = "17", LineOne = "OS and Distributions", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=17" });
            this.Items.Add(new IncidentViewModel() { ID = "18", LineOne = "Cloud", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=18" });
            this.Items.Add(new IncidentViewModel() { ID = "19", LineOne = "Virtual Network", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=19" });
            this.Items.Add(new IncidentViewModel() { ID = "20", LineOne = "ADSL / SDSL", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=19" });
            this.Items.Add(new IncidentViewModel() { ID = "21", LineOne = "Private Cloud", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=21" });
            this.Items.Add(new IncidentViewModel() { ID = "22", LineOne = "VPS", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=22" });
            this.Items.Add(new IncidentViewModel() { ID = "23", LineOne = "CDN", LineTwo = "", RssFeed = "http://travaux.ovh.net/rss.php?proj=23" });


            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}