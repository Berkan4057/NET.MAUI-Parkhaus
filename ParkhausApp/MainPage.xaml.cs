using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace ParkhausApp
{
    public partial class MainPage : ContentPage
    {

        private Ticket? _currentTicket;
        private int _nextTicketNumber = 1;  

        public MainPage()
        {
            InitializeComponent();
            
        }

          private async void OpenBarrier(object sender, EventArgs e)
        {
            barrier.Text = "Schranke offen";


            // Create a new Ticket 
            _currentTicket = new Ticket
            {
                TicketNumber = _nextTicketNumber++,
                EntryTime = DateTime.Now,
                IsPaid = false,


            };

            await DisplayAlert("Ticket", "Die Schranke ist jetzt offen.", "OK");

            await Navigation.PushAsync(new Dashboard(_currentTicket));

            barrier.Text = "Schranke geschlossen";

        }
        
        
       
     
    }
}
