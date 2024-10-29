using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Xamarin.Forms;
using Android.Bluetooth;
using Google.Android.Material.Chip;

namespace Criticografo_savr.Droid
{
    [Activity(Label = "Criticografo_savr", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
     
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
        public void EncambiodeGenero(Object sender, CheckedChangedEventArgs e)
        {
            if (F.IsChecked = true)
            {
                CambioaFemenino();
            }
            if(M.IsChecked = true)
            {
                CambioaMasculino();
            }
        }

        public void CambioaFemenino()
        {
            
            Boni.IsVisible = false;
            Agra.IsVisible = false;
            Chis.IsVisible = false;
            Comi.IsVisible = false;
            Enoj.IsVisible = false;
            Fea.IsVisible = false;
            Nolee.IsVisible = false;
            Ment.IsVisible = false;
        }
        public void CambioaMasculino()
        {
            Boni.IsVisible = true;
            Agra.IsVisible = true;
            Chis.IsVisible = true;
            Comi.IsVisible = true;
            Enoj.IsVisible = true;
            Fea.IsVisible = true;
            Nolee.IsVisible = true;
            Ment.IsVisible = true;
        }
    }
}