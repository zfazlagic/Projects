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
    public class KupiKartuViewModel : INotifyPropertyChanged
        {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
        #endregion

        #region Privatni atributi
        private string naziv;
        private int brojKarata;
        private string terminPrikazivanja;
        private string mjesto;

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

        public int BrojKarata
            {
            get
                {
                return brojKarata;
                }

            set
                {
                brojKarata = value;
                NotifyPropertyChanged("BrojKarata");
                }
            }

        public string TerminPrikazivanja
            {
            get
                {
                return terminPrikazivanja;
                }

            set
                {
                terminPrikazivanja = value;
                NotifyPropertyChanged("TerminPrikazivanja");
                }
            }

        public string Mjesto
            {
            get
                {
                return mjesto;
                }

            set
                {
                mjesto = value;
                NotifyPropertyChanged("Mjesto");
                }
            }
        #endregion
        public ICommand KupiKartu { get; set; }


        public KupiKartuViewModel ()
            {
            KupiKartu = new RelayCommand<object>(kupiKartu);
            BrojKarata = 0;
            }
        private async void kupiKartu (object obj)
            {
            //provjera da li je unesen broj kartice
            if (Convert.ToString(BrojKarata) == null)
                {
                var messageDialog = new MessageDialog("Nije unesen broj karata!", "Greška pri kupovini karte");
                await messageDialog.ShowAsync();
                }

            else
                {
                var message = new MessageDialog("Uspješno ste kupili kartu!", "Kupovina karte uspješna");
                Naziv = string.Empty;
                BrojKarata = 0;
                TerminPrikazivanja = string.Empty;
                Mjesto = string.Empty;

                }
            }
        }
    }
