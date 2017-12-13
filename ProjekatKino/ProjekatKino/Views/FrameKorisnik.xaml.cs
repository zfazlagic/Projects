using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using ProjekatKino.Helper;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatKino.Views
    {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrameKorisnik : Page
        {
        public FrameKorisnik ()
            {
            this.InitializeComponent();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;
            }

        private void ThisPage_BackRequested (object sender, BackRequestedEventArgs e)
            {
            if (Frame.CanGoBack)
                {
                Frame.Navigate(typeof(MainPage));
                e.Handled = true;
                }
            }



        private void opcijaHome_Tapped (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(FrameNaslovna));
            }

        private void Rectangle_Tapped (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(FramePosebnaPonuda));
            }

        private void Rectangle_Tapped_1 (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(FrameFindMyMovie));
            }

        private void opcijaKupiKartu_Tapped (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(FrameKupiKartu));
            }

        private void image_Tapped (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(MainPage));
            }
        }
    }
