using System.Threading.Tasks;

namespace ParkhausApp;

public partial class TicketDetailPage : ContentPage
{
	private Ticket _ticket;

	public TicketDetailPage(Ticket ticket)
	{
		InitializeComponent();

		_ticket = ticket;

        // Display ticket details
        TicketNumberLabel.Text = $"Ticket Nummer: {_ticket.TicketNumber}";
        EntryTimeLabel.Text = $"Eintritt: {_ticket.EntryTime:g}";
        IsPaidLabel.Text = $"Bezahlt: {_ticket.IsPaid}";
    }

    private async void PayButton_Clicked(object sender, EventArgs e)
    {
		_ticket.IsPaid = true;
		
		
		await DisplayAlert("Zahlung", "Die Zahlung war erfolgreich. Sie können jetzt die Schranke öffnen.", "OK");

        // Navigate back to the main page
        await Navigation.PopAsync();

    }
}