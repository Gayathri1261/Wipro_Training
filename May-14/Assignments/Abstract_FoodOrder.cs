using System;

public abstract class TicketBooking
{
    public abstract void BookTicket(int seats);
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }
}
public class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} bus tickets");
    }
}
public class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} flight tickets");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        TicketBooking busBooking = new BusBooking();
        busBooking.ShowBookingInfo();
        busBooking.BookTicket(3);

        Console.WriteLine(); 
        TicketBooking flightBooking = new FlightBooking();
        flightBooking.ShowBookingInfo();
        flightBooking.BookTicket(2);
    }
}