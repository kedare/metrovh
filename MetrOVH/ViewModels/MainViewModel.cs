using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MetrOVH.Resources;

namespace MetrOVH.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

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

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "Incidents", LineTwo = "See currents and planed incidents and interventions"});
            this.Items.Add(new ItemViewModel() { ID = "1", LineOne = "Manager", LineTwo = "Manage your services"});
            this.Items.Add(new ItemViewModel() { ID = "99", LineOne = "About", LineTwo = ""});

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