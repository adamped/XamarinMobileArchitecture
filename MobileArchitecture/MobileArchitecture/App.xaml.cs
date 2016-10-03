namespace MobileArchitecture
{
    using Framework.Interface;
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App(IPlatformBootstrapper platformBootstrapper)
        {
            InitializeComponent();

            // The root page of your application
            var content = new ContentPage
            {
                Title = "MobileArchitecture",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            var bootstrapper = Bootstrapper.GetInstance(platformBootstrapper);
            bootstrapper.Init();

            MainPage = new NavigationPage(content);
        }
    }
}
