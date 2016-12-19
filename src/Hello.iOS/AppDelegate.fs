namespace Hello.iOS

open System
open UIKit
open Foundation
open Hello

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit Xamarin.Forms.Platform.iOS.FormsApplicationDelegate ()

    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =
        // If you have defined a root view controller, set it here:
        // window.RootViewController <- new MyViewController ()
        Xamarin.Forms.Forms.Init()
        this.LoadApplication(new App())
        base.FinishedLaunching(app, options)