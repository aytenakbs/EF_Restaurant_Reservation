using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RestaurantReservation.Models;
public class Reservation:BaseModel
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime ReservationDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;

}
