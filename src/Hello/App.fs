namespace Hello
open Xamarin.Forms

type App() = 
    inherit Application()

    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let label = Label(HorizontalTextAlignment = TextAlignment.Center, 
                        Text = "Hello World!")
    
    do stack.Children.Add(label)
    do base.MainPage <- new ContentPage(Content = stack)

    override this.OnStart() =
        ()
    override this.OnSleep() =
        ()
    override this.OnResume() =
        ()
