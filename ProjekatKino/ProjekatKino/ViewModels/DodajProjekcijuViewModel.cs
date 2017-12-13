using Microsoft.WindowsAzure.MobileServices;
using ProjekatKino.Helper;
using ProjekatKino.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ProjekatKino.ViewModels
{
    public class DodajProjekcijuViewModel
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
        private string nazivFilma;
        private DateTime vrijemePrikazivanja;
        private int idFilma;
        private int idKinoDvorane;
        private DateTime datumPrikazivanja;

        private ObservableCollection<string> comboBoxOptions;
        private List<int> he;
        #endregion



        public ICommand Dodaj { get; set; }
        public ICommand Proba { get; set; }
        public Projekcija p { get; set; }
        public ICommand ideovi { get; set; }

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

        public DateTime VrijemePrikazivanja
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

        public int IdFilma
        {
            get
            {
                return idFilma;
            }

            set
            {
                idFilma = value;
                NotifyPropertyChanged("IdFilma");
            }
        }

        public int IdKinoDvorane
        {
            get
            {
                return idKinoDvorane;
            }

            set
            {
                idKinoDvorane = value;
                NotifyPropertyChanged("IdKinoDvorane");
            }
        }

        public DateTime DatumPrikazivanja
        {
            get
            {
                return datumPrikazivanja;
            }

            set
            {
                datumPrikazivanja = value;
                NotifyPropertyChanged("DatumPrikazivanja");
            }
        }

      

        public List<int> He
        {
            get
            {
                return he;
            }

            set
            {
                he = value;
                NotifyPropertyChanged("He");
            }
        }

        public ObservableCollection<string> ComboBoxOptions
        {
            get
            {
                return comboBoxOptions;
            }

            set
            {
                comboBoxOptions = value;
                NotifyPropertyChanged("ComboBoxOptions");
            }
        }

        public DodajProjekcijuViewModel()
        {
            Dodaj = new RelayCommand<object>(unosProjekcije);
            Proba = new RelayCommand<object>(unosCombo);
            ideovi = new RelayCommand<object>(unos2);

        }
        IMobileServiceTable<Film> filmic = App.MobileService.GetTable<Film>();

        private async void unos2(object obj)
        {
            for (int i = 0; i < 10; i++) He.Add(i);
        }
        private async void unosCombo(object obj)
        {
            List<Film> film = new List<Film>();
            film = await filmic.ToListAsync();
            foreach (Film f in film)
            {
                ComboBoxOptions.Add(f.naziv);
            }

        }

        IMobileServiceTable<Projekcija> userTableObj = App.MobileService.GetTable<Projekcija>();

        private async void unosProjekcije(object obj)
        {
            using (var db = new KinoDbContext())
            {
                // validacija unosa
                if (NazivFilma == "" || Convert.ToString(IdKinoDvorane) == "")
                {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    try
                    {

                        Projekcija pr = new Projekcija();

                        pr.vrijemePrikazivanja = VrijemePrikazivanja;
                        pr.idKinoDvorane = IdKinoDvorane;
                        pr.nazivFilma = NazivFilma;
                        pr.datumPrikazivanja = DatumPrikazivanja;

                        MessageDialog msgDialog = new MessageDialog("Uspješno ste dodali projekciju.");
                        msgDialog.ShowAsync();
                    }

                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                        msgDialogError.ShowAsync();
                    }




                    var unesiProjekciju = new Projekcija(VrijemePrikazivanja, IdKinoDvorane, IdFilma, NazivFilma, DatumPrikazivanja);
                    //db.filmovi.Add(unesiFilm);
                    //db.SaveChanges();

                    //var message = new MessageDialog("Uspješno je unesen novi film", "Unos filma");
                    //await message.ShowAsync();

                    NazivFilma = string.Empty;
                    VrijemePrikazivanja = DateTime.Now;
                    IdKinoDvorane = 0;
                    DatumPrikazivanja = DateTime.Now;


                }
            }
        }
    }
}
