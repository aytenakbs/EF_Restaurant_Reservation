using EF_RestaurantReservation.Models;
using EF_RestaurantReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_RestaurantReservation.Forms.Customer;
public partial class FrmAddCustomer : Form
{
    public FrmAddCustomer()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            CustomerService customerService = new CustomerService();
            EF_RestaurantReservation.Models.Customer customer = new EF_RestaurantReservation.Models.Customer();
            customer.Name = txtName.Text.Trim();
            customer.Address = txtAddress.Text.Trim();
            customer.Surname = txtSurname.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            customer.PhoneNumber = txtPhoneNumber.Text.Trim();
            customerService.AddCustomer(customer);
            dtCustomerList.DataSource=customerService.GetCustomerList();
        }
        catch (Exception)
        {
            MessageBox.Show("Yeni müşteri ekleme esnasında bir hata meydana geldi.");
        }

    }
}
