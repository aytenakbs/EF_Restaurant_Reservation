using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EF_RestaurantReservation.Models;
public class Customer:BaseModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string FullName => $"{Name} {Surname}";
    public bool IsActive { get; set; } = true;

}
