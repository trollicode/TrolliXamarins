
using Com.OneSignal;

using Foundation;
using UIKit;

namespace TrolliApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            // sendVerifi("+923333604778");
            OneSignal.Current.StartInit("8b4dd468-c131-476c-9567-b7bd4341c273")
                  .EndInit();
            return base.FinishedLaunching(app, options);
        }

     /*   private void sendVerifi(string phoneNumber) {
          PhoneAuthProvider.DefaultInstance.VerifyPhoneNumber (phoneNumber, (verificationId, error) => {
              if (error != null) {
                  //   Console.WriteLine (error.LocalizedDescription);
                  return;
                     }

    // Sign in using the verificationID and the code sent to the user
    // ...
                });
        }*/
    }
}
