using EF_RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RestaurantReservation.Services;
public class ReservationService
{
    public List<Reservation> GetReservationList()
    {
        RestaurantContext db = new RestaurantContext();
        List<Reservation> values = db.Reservations.Where(x => x.IsActive == true).ToList();
        return values;
    }
    public void AddReservation(Reservation reservation)
    {
        RestaurantContext db=new RestaurantContext();
        db.Reservations.Add(reservation);
        db.SaveChanges();
    }
    public void DeleteReservation(int id) 
    {
        RestaurantContext db = new RestaurantContext();
        Reservation value= db.Reservations.FirstOrDefault(x=>x.Id==id);
        value.IsActive=false;
        db.SaveChanges();
    }
    public Reservation GetReservationById(int id)
    {
        RestaurantContext db=new RestaurantContext();
        Reservation value = db.Reservations.FirstOrDefault(x => x.Id == id);
        return value;
    }
    public void UpdateReservation(Reservation reservation)
    {
        RestaurantContext db = new RestaurantContext();
        Reservation value=db.Reservations.FirstOrDefault(x=>x.Id==reservation.Id);
        if (value!=null)
        {
            value.Customer = reservation.Customer;
            value.ReservationDate = reservation.ReservationDate;
        }
        db.SaveChanges();
    }
    public Reservation GetReservationByCustomerId(int id)
    {
        using (RestaurantContext db = new RestaurantContext())
        {
            Reservation reservation = db.Reservations.FirstOrDefault(x => x.CustomerId == id);
            return reservation;
        }
    }

}
