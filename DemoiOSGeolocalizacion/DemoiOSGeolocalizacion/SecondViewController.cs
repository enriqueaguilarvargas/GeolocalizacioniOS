using System;
using UIKit;
using CoreLocation;
using MapKit;
using Xamarin.Essentials;
namespace DemoiOSGeolocalizacion
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Localizador = await Geolocation.GetLocationAsync();
            double Latitud = Localizador.Latitude;
            double Longitud = Localizador.Longitude;
            var Ubicacion = new CLLocation(Latitud, Longitud);
            var Georeferencia = new CLGeocoder();
            var Datos = await Georeferencia.ReverseGeocodeLocationAsync(Ubicacion);
            lblPais.Text = Datos[0].Country;
            lblEstado.Text = Datos[0].AdministrativeArea;
            lblCiudad.Text = Datos[0].Locality;
            lblColonia.Text = Datos[0].SubLocality;
            TvDescripcion.Text = Datos[0].Description;
            Mapa.MapType = MKMapType.Hybrid;
            var Centrar = new CLLocationCoordinate2D(Latitud, Longitud);
            var Altura = new MKCoordinateSpan(.003, .003);
            var Region = new MKCoordinateRegion(Centrar, Altura);
            Mapa.SetRegion(Region, true);
        }
    }
}

