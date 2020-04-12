// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DemoiOSGeolocalizacion
{
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.UILabel lblCiudad { get; set; }

		[Outlet]
		UIKit.UILabel lblColonia { get; set; }

		[Outlet]
		UIKit.UILabel lblEstado { get; set; }

		[Outlet]
		UIKit.UILabel lblPais { get; set; }

		[Outlet]
		MapKit.MKMapView Mapa { get; set; }

		[Outlet]
		UIKit.UITextView TvDescripcion { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Mapa != null) {
				Mapa.Dispose ();
				Mapa = null;
			}

			if (lblPais != null) {
				lblPais.Dispose ();
				lblPais = null;
			}

			if (lblEstado != null) {
				lblEstado.Dispose ();
				lblEstado = null;
			}

			if (lblCiudad != null) {
				lblCiudad.Dispose ();
				lblCiudad = null;
			}

			if (lblColonia != null) {
				lblColonia.Dispose ();
				lblColonia = null;
			}

			if (TvDescripcion != null) {
				TvDescripcion.Dispose ();
				TvDescripcion = null;
			}
		}
	}
}
