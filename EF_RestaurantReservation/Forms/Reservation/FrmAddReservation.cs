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

namespace EF_RestaurantReservation.Forms.Reservation;
public partial class FrmAddReservation : Form
{
    public FrmAddReservation()
    {
        InitializeComponent();
    }

    private void FrmAddReservation_Load(object sender, EventArgs e)
    {
        ReservationService reservationService = new ReservationService();
        CustomerService customerService = new CustomerService();
        dgvReservation.DataSource = reservationService.GetReservationList();
        RestaurantContext db = new RestaurantContext();
        List<Models.Customer> list =customerService.GetCustomerList();
        cmbCustomer.ValueMember = "Id";
        cmbCustomer.DisplayMember = "FullName";
        cmbCustomer.DataSource = list;
        dtpRes_Date.Value = DateTime.Now;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        ReservationService reservationService=new ReservationService();
        Models.Reservation reservation=new Models.Reservation();
        Models.Customer selectedCustomer=(Models.Customer)cmbCustomer.SelectedItem;
        reservation.CustomerId = selectedCustomer.Id;
        reservation.ReservationDate = dtpRes_Date.Value;
        if (reservation!=null)
        {
            reservationService.AddReservation(reservation);
        }
        dgvReservation.DataSource=reservationService.GetReservationList();
    }
}
