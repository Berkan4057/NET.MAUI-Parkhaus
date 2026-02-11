namespace ParkhausApp;

public partial class Dashboard : ContentPage
{
    private Ticket _ticket;

    public Dashboard(Ticket ticket)
	{
		InitializeComponent();
		_ticket = ticket;

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
}