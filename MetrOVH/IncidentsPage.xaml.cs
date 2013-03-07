using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MetrOVH.ViewModels;

namespace MetrOVH
{
    public partial class IncidentsPage : PhoneApplicationPage
    {

        IncidentViewModel ViewModel;

        public IncidentsPage()
        {
            InitializeComponent();

            // Set the data context of the LongListSelector control to the sample data
            ViewModel = new IncidentViewModel();
            this.DataContext = ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!ViewModel.IsDataLoaded)
            {
                ViewModel.LoadData();
            }
        }

        // Handle selection changed on LongListSelector
        private void IncidentLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected item is null (no selection) do nothing
            if (IncidentLongListSelector.SelectedItem == null)
                return;


            string categoryName = (IncidentLongListSelector.SelectedItem as IncidentViewModel).LineOne;
            string rssFeed = (IncidentLongListSelector.SelectedItem as IncidentViewModel).RssFeed;


            (Application.Current as App).CurrentFeedName = categoryName;
            (Application.Current as App).CurrentFeedUrl = rssFeed;


            // Navigate to the new page
            NavigationService.Navigate(new Uri("/IncidentCategoryPage.xaml", UriKind.Relative));

            // Reset selected item to null (no selection)
            IncidentLongListSelector.SelectedItem = null;
        }
    }
}