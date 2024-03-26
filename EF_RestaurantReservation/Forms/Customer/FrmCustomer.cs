
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_RestaurantReservation.Models;
using EF_RestaurantReservation.Services;

namespace EF_RestaurantReservation.Forms.Customer;
public partial class FrmCustomer : Form
{
    public FrmCustomer()
    {
        InitializeComponent();
    }

    private void FrmCustomer_Load(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        dtGridCustomerList.DataSource = customerService.GetCustomerList();
    }

    private void grpBoxSelectedCustomer_Enter(object sender, EventArgs e)
    {

    }

    private void dtGridCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dtGridCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dtGridCustomerList.CurrentRow.Cells[5].Value);
        RestaurantContext db = new RestaurantContext();
        CustomerService customerService = new CustomerService();
        Models.Customer customer = customerService.GetCustomerById(id);
        if (customer != null)
        {
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtSurname.Text = customer.Surname;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
        }

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        Models.Customer customer = new Models.Customer();
        customer.Id= Convert.ToInt32(dtGridCustomerList.Rows[0].Cells[5].Value); 
        customer.Name = txtName.Text;
        customer.Address = txtAddress.Text;
        customer.Surname = txtSurname.Text;
        customer.PhoneNumber = txtPhoneNumber.Text;
        customer.Email = txtEmail.Text;
        customerService.UpdateCustomer(customer);
        dtGridCustomerList.DataSource = customerService.GetCustomerList();

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        CustomerService customerService= new CustomerService();
        int id = Convert.ToInt32(dtGridCustomerList.CurrentRow.Cells[5].Value);
        customerService.DeleteCustomer(id);
        dtGridCustomerList.DataSource = customerService.GetCustomerList();
    }
}
