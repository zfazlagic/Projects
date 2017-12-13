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
    public class FindMyMovieViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        #region Privatni 
        private string nazivFilma;
        private string vrijemePrikazivanja;
        private int brojKarti;
        private string dvorana;

        public string NazivFilma
            {
            get
                {
                return nazivFilma;
                }

            set
                {
                nazivFilma = value;
                NotifyPropertyChanged("NazivFilma");
                }
            }

        public string VrijemePrikazivanja
            {
            get
                {
                return vrijemePrikazivanja;
                }

            set
                {
                vrijemePrikazivanja = value;
                NotifyPropertyChanged("VrijemePrikazivanja");
                }
            }

        public int BrojKarti
            {
            get
                {
                return brojKarti;
                }

            set
                {
                brojKarti = value;
                NotifyPropertyChanged("BrojKarti");
                }
            }

        public string Dvorana
            {
            get
                {
                return dvorana;
                }

            set
                {
                dvorana = value;
                }
            }
        #endregion


        




        public ICommand FindKupiKartu { get; set; }

        

        public FindMyMovieViewModel ()
            {
            FindKupiKartu = new RelayCommand<object>(kupiFindKartu);
            BrojKarti = 0;
            }
        private async void kupiFindKartu (object obj)
            {

            if (Convert.ToString(BrojKarti) == null)
                {
                var messageDialog = new MessageDialog("Nije unesen broj karata!", "Greška pri kupovini karte");
                await messageDialog.ShowAsync();
                }



            else
                {
                var message = new MessageDialog("Uspješno ste kupili kartu!", "Kupovina karte uspješna");
                NazivFilma = string.Empty;
                VrijemePrikazivanja = string.Empty;
                BrojKarti = 0;

                }
            }

        public async void dajLokaciju()
            {
            //dvorana = (GetDistanceInKm(43.8562586, 18.4130763, ));
            }

        double GetDistanceInKm (double lat1, double lon1, double lat2, double lon2)
            {
            var R = 6371d;
            var dLat = Deg2Rad(lat2 - lat1);
            var dLon = Deg2Rad(lon2 - lon1);
            var a =
              Math.Sin(dLat / 2d) * Math.Sin(dLat / 2d) +
              Math.Cos(Deg2Rad(lat1)) * Math.Cos(Deg2Rad(lat2)) *
              Math.Sin(dLon / 2d) * Math.Sin(dLon / 2d);
            var c = 2d * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1d - a));
            var d = R * c;
            return d;
            }

        double Deg2Rad (double deg)
            {
            return deg * (Math.PI / 180d);
            }






        }
    }
