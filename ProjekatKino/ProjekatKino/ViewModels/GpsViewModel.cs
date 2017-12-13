using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml.Controls.Maps;

namespace ProjekatKino.ViewModels
    {
    public class GpsViewModel : INotifyPropertyChanged
        {
        private Geopoint trenutnaLokacija;
        public string dvorana { get; set; }
        public Geopoint lokacijaKina { get; set; }
        public Geopoint TrenutnaLokacija
            {
            get { return trenutnaLokacija; }
            set
                {
                trenutnaLokacija = value;
                OnNotifyPropertyChanged("TrenutnaLokacija");
                }
            }

        //string lokacije za ispis u textBlock/adresa isto
        private string lokacija;
        public string Lokacija
            {
            get { return lokacija; }
            set
                {
                lokacija = value;
                OnNotifyPropertyChanged("Lokacija");
                }
            }
        private string adresa;
        public string Adresa
            {
            get { return adresa; }
            set
                {
                adresa = value;
                OnNotifyPropertyChanged("Adresa");
                }
            }
        //krsenje mvvm za mapu .. neophodno
        MapControl Mapa;
        public GpsViewModel (MapControl mapa)
            {
            Mapa = mapa; dajLokaciju();
            }
        public async void dajLokaciju ()
            {



            Geoposition pos = null;
            // da li se smije uzeti lokacija, trazi se odobrenje od korisnika (takodjer treba i capability)
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus == GeolocationAccessStatus.Allowed)
                {
                //uzimanje pozicije ako smije
                Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 10 };
                pos = await geolocator.GetGeopositionAsync();
                }
            // tacka iz pozicije
            TrenutnaLokacija = pos.Coordinate.Point;
            Lokacija = "Geolokacija Lat: " + TrenutnaLokacija.Position.Latitude + " Lng: " +
           TrenutnaLokacija.Position.Longitude;

            dvorana = (Math.Round(GetDistanceInKm(43.8562586, 18.4130763, TrenutnaLokacija.Position.Latitude, TrenutnaLokacija.Position.Longitude),2)).ToString();


            // uzeti adresu na osnovu GeoTacke
            MapLocationFinderResult result = await
            MapLocationFinder.FindLocationsAtAsync(pos.Coordinate.Point);

            // Nadje li adresu ispisi je
            if (result.Status == MapLocationFinderStatus.Success)
                {
                Adresa = "Vasa udaljenost od kina je " + dvorana + " km. Adresa najblize dvorane je : Valtera Perica ";
                //Adresa = "Vaša lokacija je " + result.Locations[0].Address.Street;
                }

            //nacrtati pravougaonik na mapi za oblast gdje bi korisnik mogao biti
            double centerLatitude = Mapa.Center.Position.Latitude;
            double centerLongitude = Mapa.Center.Position.Longitude;
            MapPolyline mapPolyline = new MapPolyline();
            mapPolyline.Path = new Geopath(new List<BasicGeoposition>() {
                               new BasicGeoposition() {Latitude=centerLatitude-0.0005,
                                                       Longitude=centerLongitude-0.001 },
                               new BasicGeoposition() {Latitude=centerLatitude+0.0005,
                                                       Longitude=centerLongitude-0.001 },
                               new BasicGeoposition() {Latitude=centerLatitude+0.0005,
                                                       Longitude=centerLongitude+0.001 },
                               new BasicGeoposition() {Latitude=centerLatitude-0.0005,
                                                       Longitude=centerLongitude+0.001 },
                               new BasicGeoposition() {Latitude=centerLatitude-0.0005,
                                                       Longitude=centerLongitude-0.001 }
            });
            mapPolyline.StrokeColor = Colors.Black;
            mapPolyline.StrokeThickness = 3;
            mapPolyline.StrokeDashed = true;
            Mapa.MapElements.Add(mapPolyline);
            }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged ([CallerMemberName] string memberName = "")
            {
            //? je skracena verzija ako nije null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
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
