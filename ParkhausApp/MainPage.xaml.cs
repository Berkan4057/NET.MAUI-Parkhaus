using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;


namespace ParkhausApp
{
    public partial class MainPage : ContentPage
    {
        private ParkingGarage _parkingGarage;
        private ParkingGarage Nr1;
        private ParkingGarage Nr2;
        private ParkingGarage Nr3;


        public MainPage()
        {
            InitializeComponent();
            var random = new Random();


            Nr1 = new ParkingGarage { ParkName = "Parkhaus KLH", Capacity = 100, FreeSpaces = random.Next(1, 101) };
            Nr2 = new ParkingGarage { ParkName = "Parkhaus Bibliothek", Capacity = 100, FreeSpaces = random.Next(1, 101) };
            Nr3 = new ParkingGarage {ParkName = "Parkhaus GYM", Capacity = 100, FreeSpaces = random.Next(1, 101) };
            
           ButtonKLH.Text = $"{Nr1.ParkName}: {Nr1.FreeSpaces} freie Plätze";
           ButtonBibliothek.Text = $"{Nr2.ParkName}: {Nr2.FreeSpaces} freie Plätze";
           ButtonGYM.Text = $"{Nr3.ParkName}: {Nr3.FreeSpaces} freie Plätze";

        
        
        }


        private async void ButtonChose(object sender, EventArgs e) 
        
            => await Navigation.PushAsync(new Barrier());

        

    }
}
