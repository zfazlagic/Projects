using Microsoft.WindowsAzure.MobileServices;
using ProjekatKino.Helper;
using ProjekatKino.Models;
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
    public class DodajProizvodViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region Privatni Atributi
        private string naziv;
        private double cijena;
        private string vrsta;

        #endregion

        #region Get,Set

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

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
                NotifyPropertyChanged("Cijena");
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
                NotifyPropertyChanged("Vrsta");
            }
        }


        #endregion

        public ICommand Dodaj { get; set; }
        public Proizvod proizvod { get; set; }

        IMobileServiceTable<Proizvod> userTableObj = App.MobileService.GetTable<Proizvod>();

        public DodajProizvodViewModel()
        {
            Dodaj = new RelayCommand<object>(unosProizvoda);
        }

        //public bool daLiJeBroj (string s) u slucaju da samo int cijena bude, koristimo pri validiranju
        //    {
        //    char[] niz = s.ToCharArray();
        //    for (int i = 0; i < niz.Length; i++)
        //        {
        //        if (!char.IsDigit(niz[i]))
        //            return false;
        //        }
        //    return true;
        //    }

        private async void unosProizvoda(object obj)
        {
            using (var db = new KinoDbContext())
            {
                // validacija unosa
                if (Naziv == "" || Cijena == 0 || Vrsta == "")
                {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    try
                    {
                        Proizvod p = new Proizvod();
                        p.naziv = Naziv;
                        p.cijena = Cijena;
                        p.vrsta = Vrsta;
                        userTableObj.InsertAsync(p);
                        MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novi proizvod.");
                        msgDialog.ShowAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                        msgDialogError.ShowAsync();
                    }

                    var unesiProizvod = new Proizvod(Naziv, Cijena, Vrsta);
                    /* db.proizvodi.Add(unesiProizvod);
                     db.SaveChanges();

                     var message = new MessageDialog("Uspješno je unesen novi proizvod", "Unos proizvoda");
                     await message.ShowAsync();*/

                    Naziv = string.Empty;
                    Cijena = 0;
                    Vrsta = string.Empty;


                }
            }
        }
    }
}
