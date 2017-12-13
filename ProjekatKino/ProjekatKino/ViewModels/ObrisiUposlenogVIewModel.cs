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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.MobileServices.Query;
namespace ProjekatKino.ViewModels
    {
    public class ObrisiUposlenogVIewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        private int id;

        public int Id
            {
            get
                {
                return id;
                }

            set
                {
                id = value;
                }
            }
        public ICommand ObrisiUposlenog { get; set; }

        public ObrisiUposlenogVIewModel ()
            {
            ObrisiUposlenog = new RelayCommand<object>(obrisi);

            }
        private async void obrisi (object obj)
            {
            //provjera da li je unesen broj kartice
            if (Convert.ToString(Id) == null)
                {
                var messageDialog = new MessageDialog("Nije unesen id!", "Greška pri unosu");
                await messageDialog.ShowAsync();
                }



            else
                {
                // SQLite Baza brisanje
                //using (var db = new KinoDbContext())
                //{
                //    foreach (Uposlenik u in db.uposlenici)
                //    {
                //        if (u.id == id) db.uposlenici.Remove(u);
                //    }
                //}
                //var message = new MessageDialog("Uspješno ste obrisali uposlenog!", "Brisanje uspješno");
                //Id = 0;



                }
            }
        }
    }
