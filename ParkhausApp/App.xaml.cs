namespace ParkhausApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // New Site
            MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new MainPage());

        }

       
    }
}