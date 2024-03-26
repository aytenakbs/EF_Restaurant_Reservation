using EF_RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RestaurantReservation.Services;
public class CustomerService
{
    public List<Customer> GetCustomerList()
    {
        RestaurantContext db = new RestaurantContext();
        List<Customer> customers = db.Customers.ToList();
        return customers;
    }
    public void AddCustomer(Customer customer)
    {
        RestaurantContext db = new RestaurantContext();
        db.Customers.Add(customer);
        db.SaveChanges();

    }
    public Customer GetCustomerById(int id)
    {
        RestaurantContext db = new RestaurantContext();
        Customer customer = db.Customers.FirstOrDefault(x => x.Id == id);
        return customer;
    }

    public void UpdateCustomer(Customer customer)
    {
        RestaurantContext db = new RestaurantContext();
        Customer value = db.Customers.FirstOrDefault(x => x.Id == customer.Id);
        if (value != null)
        {
            value.Id = customer.Id;
            value.Address = customer.Address;
            value.Name = customer.Name;
            value.Surname = customer.Surname;
            value.Email = customer.Email;
            value.PhoneNumber = customer.PhoneNumber;
            db.Customers.Update(value);
            db.SaveChanges();
        }


    }
    public void DeleteCustomer(int id)
    {
        RestaurantContext db = new RestaurantContext();
        var value = db.Customers.FirstOrDefault(x => x.Id == id);
        db.Customers.Remove(value);
        db.SaveChanges();

    }
}
