﻿using ParKing.Helper;
using ParKing.Model;
using ParKing.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParKing.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListaParkinga : Page
    {
        INavigationService NavigationService { get; set; }
        public ListaParkinga()
        {
            this.InitializeComponent();
            this.DataContext = new ListaParkingaViewModel();
            NavigationService = new NavigationService();
        }

        private void ListaParkingaListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var parking = (Parking)ListaParkingaListBox.SelectedItem;

            NavigationService.Navigate(typeof(View.DetaljiParkinga), parking);
        }
    }
}
