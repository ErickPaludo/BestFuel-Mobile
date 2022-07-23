using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class App : Application
    {
        public App()
        {

            var imagem1 = new Image
            {
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };
            imagem1.Source = ImageSource.FromFile("background.jpg");

            InitializeComponent();
#if DEBUG
            HotReloader.Current.Run(this);
#endif

            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
