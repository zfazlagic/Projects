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
using ProjekatKino.Views;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatKino
    {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
        {
        public MainPage ()
            {
            this.InitializeComponent();
            }

        private void button_Tapped (object sender, TappedRoutedEventArgs e)
            {
            this.Frame.Navigate(typeof(AdminDodajProjekciju));
            }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "admin") this.Frame.Navigate(typeof(AdminPocetna));
            else if(textBox.Text=="korisnik") this.Frame.Navigate(typeof(FrameKorisnik));
            else if (textBox.Text == "") {
                var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                messageDialog.ShowAsync();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FrameGost));
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FrameRegistracija));
        }
    }
    }
