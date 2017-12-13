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

namespace ProjekatKino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPocetna : Page
    {
        public AdminPocetna()
        {
            this.InitializeComponent();
        }

        private void RelativePanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminDodajProjekciju));
        }

        private void RelativePanel_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminDodajUposlenog));
        }

        private void RelativePanel_PointerPressed_2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminObrisiUposlenog));
        }

        private void RelativePanel_PointerPressed_3(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminTehnicki));
        }

        private void RelativePanel_PointerPressed_4(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminDodajProizvod));
        }

        private void RelativePanel_PointerPressed_5(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminDodajFilm));
        }
    }
}
