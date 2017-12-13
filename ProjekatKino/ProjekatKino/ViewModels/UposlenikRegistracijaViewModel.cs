using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjekatKino.Helper;
using System.Linq;
using Windows.UI.Popups;
using System.Threading.Tasks;
using ProjekatKino.Models;
using System.Text;
using System.Windows.Input;
using Microsoft.WindowsAzure.MobileServices;

namespace ProjekatKino.ViewModels
    {
    public class UposlenikRegistracijaViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        #region Privatni Atributi
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private string username;
        private string password;
        private Int64 maticniBroj;
        private DateTime datumRodjenja;
        #endregion

        #region Get,Set

        public string Ime
            {
            get
                {
                return ime;
                }

            set
                {
                ime = value;
                NotifyPropertyChanged("Ime");
                }
            }

        public string Prezime
            {
            get
                {
                return prezime;

                }

            set
                {
                prezime = value;
                NotifyPropertyChanged("Prezime");
                }
            }

        public string Email
            {
            get
                {
                return email;

                }

            set
                {
                email = value;
                NotifyPropertyChanged("Email");
                }
            }

        public string Adresa
            {
            get
                {
                return adresa;
                }

            set
                {
                adresa = value;
                NotifyPropertyChanged("Adresa");
                }
            }


        public Int64 MaticniBroj
            {
            get
                {
                return maticniBroj;
                }

            set
                {
                maticniBroj = value;
                NotifyPropertyChanged("MaticniBroj");
                }
            }

        public DateTime DatumRodjenja
            {
            get
                {
                return datumRodjenja;
                }

            set
                {
                datumRodjenja = value;
                NotifyPropertyChanged("DatumRodjenja");
                }
            }
        public string Username
            {
            get
                {
                return username;
                }

            set
                {
                username = value;
                NotifyPropertyChanged("Username");
                }
            }

        public string Password
            {
            get
                {
                return password;
                }

            set
                {
                password = value;
                NotifyPropertyChanged("Password");
                }
            }

        #endregion

        public ICommand Dodaj { get; set; }
        public Uposlenik uposlenik { get; set; }

        IMobileServiceTable<Uposlenik> userTableObj = App.MobileService.GetTable<Uposlenik>();

        public UposlenikRegistracijaViewModel ()
            {
            Dodaj = new RelayCommand<object>(unosUposlenog);
            }

        private async void unosUposlenog (object obj)
            {
            using (var db = new KinoDbContext())
                {
                // validacija unosa
                if (Ime == "" || Prezime == "" || Adresa == "" || Email == "" || Username == "" || Password == "" || DatumRodjenja == null || MaticniBroj == 0)
                    {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                    }
                if (Username.Length < 7 || Username.Length > 22)
                    {
                    var messageDialog = new MessageDialog("Username mora imati najmanje 7, a najvise 22 karaktera");
                    await messageDialog.ShowAsync();
                    }
                if (Password.Length < 8 || Password.Length > 22)
                    {
                    var messageDialog = new MessageDialog("Password mora imati najmanje 8, a najvise 22 karaktera");
                    await messageDialog.ShowAsync();
                    }

                try
                    {

                    Uposlenik kor = new Uposlenik();
                    kor.ime = Ime;
                    kor.prezime = Prezime;
                    kor.adresa = Adresa;
                    kor.email = Email;
                    kor.username = Username;
                    kor.password = Password;
                    kor.datumRodjenja = DatumRodjenja;
                    kor.maticniBroj = MaticniBroj;
                    userTableObj.InsertAsync(kor);

                    MessageDialog msgDialog = new MessageDialog("Uspješno ste dodali uposlenika.");
                    msgDialog.ShowAsync();
                    }

                catch (Exception ex)
                    {
                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                    }




                var uneseniUposlenik = new Uposlenik(Ime, Prezime, Adresa, Email, Username, Password, Convert.ToDateTime(DatumRodjenja), MaticniBroj);
                // SQLite baza
                //db.uposlenici.Add(uneseniUposlenik);
                //db.SaveChanges();

                //var message = new MessageDialog("Uspješno je unesen novi radnik", "Unos radnika");
                //await message.ShowAsync();

                Ime = string.Empty;
                Prezime = string.Empty;
                Username = string.Empty;
                Password = string.Empty;
                Adresa = string.Empty;
                Email = string.Empty;
                }
            }




        }
    }
