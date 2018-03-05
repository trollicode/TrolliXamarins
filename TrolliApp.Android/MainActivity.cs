using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Java.Util.Concurrent;

using Android.Util;
using Java.Security;
using Com.OneSignal;

namespace TrolliApp.Droid
{
    [Activity(Label = "TrolliApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        // public PhoneAuthProvider.OnVerificationStateChangedCallbacks mCallBack;
        // PhoneAuthProvider.ForceResendingToken mResendToken;
        //Class1 Cls = new Class1();

     
        // PhoneAuthCredential credentail = new PhoneAuthCredential();
        // private PhoneAuthProvider.OnVerificationStateChangedCallbacks mCallBack;
        //  public static FirebaseOptions options;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            OneSignal.Current.StartInit("8b4dd468-c131-476c-9567-b7bd4341c273")
                .InFocusDisplaying(Com.OneSignal.Abstractions.OSInFocusDisplayOption.Notification)
                .EndInit();
            OneSignal.Current.PromptLocation();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            
        }
    }
         

    }



