namespace ParkhausApp;

public partial class Dashboard : ContentPage
{
    private Ticket _ticket;

    public Dashboard(Ticket ticket)
	{
		InitializeComponent();
		_ticket = ticket;
        TicketNumberLabel.Text = $"Ticket Nummer: {_ticket.TicketNumber}";
        IsPaidLabel.Text = $"Bezahlt: {_ticket.IsPaid}";
        EntryTimeLabel.Text = $"Eintritt: {_ticket.EntryTime:g}";


    }
	protected override void OnAppearing()
	{
		base.OnAppearing();
		StartParkingTimer();
		CurrentPrice();
        

    }


	public void StartParkingTimer()
	{
	

		// override UI
		Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
		{
			
			var duration = DateTime.Now - _ticket.EntryTime;
            CurrentParkTimeLabel.Text = $"Aktuelle Parkzeit: {duration:hh\\:mm\\:ss}";
            return true; 

		});
		
    }
	public void CurrentPrice()
	{ 
	Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
		{
            var Time = DateTime.Now - _ticket.EntryTime;
            var TimeMinute = Math.Floor(Time.TotalMinutes);
            double price = TimeMinute / 1 * 2;
            CurrentPriceLabel.Text = $"Aktuelle Preis: {price} CHF";
            return true;

        });

    }
    private async void PayButton_Clicked(object sender, EventArgs e)
    {
        _ticket.IsPaid = true;


        await DisplayAlert("Zahlung", "Die Zahlung war erfolgreich. Sie können jetzt die Schranke öffnen.", "OK");

        // Navigate back to the main page
        await Navigation.PopAsync();

    }


}