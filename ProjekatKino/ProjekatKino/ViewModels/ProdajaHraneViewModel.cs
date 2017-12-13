using ProjekatKino.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ProjekatKino.ViewModels
{
   public class ProdajaHraneViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private string naziv;

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
                NotifyPropertyChanged("Naziv");
            }
        }
        public ICommand ProdajHranu { get; set; }


        public ProdajaHraneViewModel()
        {
            ProdajHranu = new RelayCommand<object>(prodajHranu);
            
        }
        private async void prodajHranu(object obj)
        {
            
            var message = new MessageDialog("Uspješno ste prodaj hranu!", "Prodaja hrane uspješna");
            await message.ShowAsync();
            Naziv = string.Empty;
                

            }
        }
    }

