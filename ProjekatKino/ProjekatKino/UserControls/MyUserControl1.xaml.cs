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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ProjekatKino.UserControls
    {
    public sealed partial class MyUserControl1 : UserControl
        {
        public MyUserControl1 ()
            {
            this.InitializeComponent();
            }


        public string opis
            {
            get { return (string)GetValue(opisProperty); }
            set { SetValue(opisProperty, value); }
            }

        // Using a DependencyProperty as the backing store for opis.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty opisProperty =
            DependencyProperty.Register("opis", typeof(string), typeof(MyUserControl1), null);



        public ImageSource slika
            {
            get { return (ImageSource)GetValue(slikaProperty); }
            set { SetValue(slikaProperty, value); }
            }

        // Using a DependencyProperty as the backing store for slika.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty slikaProperty =
            DependencyProperty.Register("slika", typeof(ImageSource), typeof(MyUserControl1), null);




        }
    }
