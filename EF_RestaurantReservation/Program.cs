using EF_RestaurantReservation.Forms.Customer;
using EF_RestaurantReservation.Forms.Menu;
using EF_RestaurantReservation.Forms.Reservation;

namespace EF_RestaurantReservation;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmReservation());
    }
}