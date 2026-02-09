using System.Threading.Tasks;

namespace ParkhausApp
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

     private async void OpenBarrier(object sender, EventArgs e)
        {
            barrier.Text = "Schranke offen";
            await DisplayAlert("Schranke", "Die Schranke ist jetzt offen.", "OK");

        }
    }
}
