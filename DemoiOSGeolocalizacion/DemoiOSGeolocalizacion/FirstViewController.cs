using System;
using Foundation;
using UIKit;
using CoreGraphics;
using Xamarin.Controls;
using AVFoundation;
using LocalAuthentication;
namespace DemoiOSGeolocalizacion
{
    public partial class FirstViewController : UIViewController
    {
        AVSpeechSynthesizer habla = new AVSpeechSynthesizer();
        public UIDynamicAnimator Animador { get; set; }
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }
        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            var verifica = new LAContext();
            var autoriza = await verifica.EvaluatePolicyAsync
                (LAPolicy.DeviceOwnerAuthenticationWithBiometrics,
                "Autenticación FaceID");
            
            if (autoriza.Item1)
            {
                var voz = new AVSpeechUtterance("Está usted autorizado en la Aplicación, sea Bienvenido");
                voz.Voice = AVSpeechSynthesisVoice.FromLanguage("es-MX");
                habla.SpeakUtterance(voz);
                lblEstatus.Text = "Autorizado";
            }
            else
            {
                lblEstatus.Text = "No Autorizado";
            
                var Gravedad = new UIGravityBehavior(Imagen, btnConfirmar, btnGuardar, lblEstatus);
                var Colision = new UICollisionBehavior(Imagen, btnConfirmar, btnGuardar, lblEstatus)
                {
                    TranslatesReferenceBoundsIntoBoundary = false
                };
                var Rebote = new UIDynamicItemBehavior(btnConfirmar)
                {
                 Elasticity = 1f
                };
                Animador = new UIDynamicAnimator(View);
                Animador.AddBehaviors(Gravedad, Colision, Rebote);
                System.Threading.Thread.CurrentThread.Abort();
                }
                var Firma = new SignaturePadView(View.Frame)
                {
                    StrokeWidth = 3f,
                    StrokeColor = UIColor.Black,
                    BackgroundColor = UIColor.White,
                };
                Firma.Frame = new CGRect(10, 500, 350, 200);
                Firma.Layer.BorderWidth = 1f;
                Firma.SignaturePrompt.TextColor = UIColor.Blue;
                Firma.Caption.TextColor = UIColor.White;
                Firma.Caption.Text = "Firmar en esta zona";
                View.AddSubview(Firma);
                
            btnConfirmar.TouchUpInside += delegate
            {
                Imagen.Image = Firma.GetImage();
        	};
            btnGuardar.TouchUpInside += delegate
            {
                var imagenfirma = Firma.GetImage();
                try
                {
                    imagenfirma.SaveToPhotosAlbum(delegate
                    (UIImage imagen, NSError error)
                    { });
                    lblEstatus.Text = "Guardado en biblioteca";
                }
                catch (Exception ex)
                {
                    lblEstatus.Text = ex.Message;
                }
        	};
        }
    }
}