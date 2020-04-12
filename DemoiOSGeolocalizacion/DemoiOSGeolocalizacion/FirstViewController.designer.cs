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
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		UIKit.UIButton btnConfirmar { get; set; }

		[Outlet]
		UIKit.UIButton btnGuardar { get; set; }

		[Outlet]
		UIKit.UIImageView Imagen { get; set; }

		[Outlet]
		UIKit.UILabel lblEstatus { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Imagen != null) {
				Imagen.Dispose ();
				Imagen = null;
			}

			if (lblEstatus != null) {
				lblEstatus.Dispose ();
				lblEstatus = null;
			}

			if (btnConfirmar != null) {
				btnConfirmar.Dispose ();
				btnConfirmar = null;
			}

			if (btnGuardar != null) {
				btnGuardar.Dispose ();
				btnGuardar = null;
			}
		}
	}
}
