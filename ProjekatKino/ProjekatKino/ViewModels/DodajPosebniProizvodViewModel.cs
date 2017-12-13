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
    public class DodajPosebniProizvodViewModel : INotifyPropertyChanged
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
        private string nazivPosebnog;
        private double cijenaPosebnog;
        private string velicinaPosebnog;
        private string sadrzaj1;
        private string sadrzaj2;
        private string kratakOpisPosebnog;


        #endregion

        #region Get,Set

        public string NazivPosebnog
        {
            get
            {
                return nazivPosebnog;
            }

            set
            {
                nazivPosebnog = value;
                NotifyPropertyChanged("NazivPosebnog");
            }
        }

        public double CijenaPosebnog
        {
            get
            {
                return cijenaPosebnog;
            }

            set
            {
                cijenaPosebnog = value;
                NotifyPropertyChanged("CijenaPosebnog");
            }
        }

        public string VelicinaPosebnog
        {
            get
            {
                return velicinaPosebnog;
            }

            set
            {
                velicinaPosebnog = value;
                NotifyPropertyChanged("VelicinaPosebnog");
            }
        }
        public string Sadrzaj1
        {
            get
            {
                return sadrzaj1;
            }

            set
            {
                sadrzaj1 = value;
                NotifyPropertyChanged("Sadrzaj1");
            }
        }

        public string Sadrzaj2
        {
            get
            {
                return sadrzaj2;
            }

            set
            {
                sadrzaj2 = value;
                NotifyPropertyChanged("Sadrzaj2");
            }
        }

        public string KratakOpisPosebnog
        {
            get
            {
                return kratakOpisPosebnog;
            }

            set
            {
                kratakOpisPosebnog = value;
                NotifyPropertyChanged("KratakOpisPosebnog");
            }
        }


        #endregion

        public ICommand DodajPosebni { get; set; }
        public PosebnePonude posebne { get; set; }



        public DodajPosebniProizvodViewModel()
        {
            DodajPosebni = new RelayCommand<object>(unosProizvoda);
        }

        IMobileServiceTable<PosebnePonude> userTableObj = App.MobileService.GetTable<PosebnePonude>();

        private async void unosProizvoda(object obj)
        {
            using (var db = new KinoDbContext())
            {
                // validacija unosa 
                if (NazivPosebnog == "" || CijenaPosebnog == 0 || VelicinaPosebnog == "" || Sadrzaj1 == "" || Sadrzaj2 == "" || KratakOpisPosebnog == "")
                {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                }
                if (KratakOpisPosebnog.Length < 10)
                {
                    var messageDialog = new MessageDialog("Prekratak opis!");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    try
                    {

                        PosebnePonude kor = new PosebnePonude();
                        kor.naziv = NazivPosebnog;
                        kor.cijena = CijenaPosebnog;
                        kor.velicina = VelicinaPosebnog;
                        kor.sadrzaj1 = Sadrzaj1;
                        kor.sadrzaj2 = Sadrzaj2;
                        kor.kratakOpis = KratakOpisPosebnog;
                        userTableObj.InsertAsync(kor);

                        MessageDialog msgDialog = new MessageDialog("Uspješno ste dodali posebni proizvod.");
                        msgDialog.ShowAsync();
                    }

                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                        msgDialogError.ShowAsync();
                    }

                    var unesiProizvod = new PosebnePonude(NazivPosebnog, CijenaPosebnog, VelicinaPosebnog, Sadrzaj1, Sadrzaj2, KratakOpisPosebnog);

                    //db.posebnePonude.Add(unesiProizvod);
                    //db.SaveChanges();
                    //var message = new MessageDialog("Uspješno je unesena nova posebna ponuda", "Unos posebne ponude");
                    //await message.ShowAsync();

                    NazivPosebnog = string.Empty;
                    CijenaPosebnog = 0;
                    VelicinaPosebnog = string.Empty;
                    Sadrzaj1 = string.Empty;
                    Sadrzaj2 = string.Empty;
                    KratakOpisPosebnog = string.Empty;


                }
            }
        }
    }
}