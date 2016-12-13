namespace Hello.Droid

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

type Resources = Hello.Droid.Resource

[<Activity (Label = "Hello.Droid", MainLauncher = true)>]
type MainActivity () =
    inherit Activity ()

    let mutable count:int = 1

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        // Set our view from the "main" layout resource
        this.SetContentView (Resources.Layout.Main)

        // Get our button from the layout resource, and attach an event to it
        let button = this.FindViewById<Button>(Resources.Id.MyButton)
        button.Click.Add (fun args -> 
            button.Text <- sprintf "%d clicks!" count
            count <- count + 1
        )



