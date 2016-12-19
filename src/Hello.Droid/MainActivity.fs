namespace Hello.Droid

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

open Hello

type Resources = Hello.Droid.Resource

[<Activity (Label = "Hello.Droid", Icon = "@drawable/icon",  MainLauncher = true)>]
type MainActivity () =
    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()

    let mutable count:int = 1

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init(this, bundle)
        this.LoadApplication(new App())


