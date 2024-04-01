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
public partial class FrmReservation : Form
{
    public FrmReservation()
    {
        InitializeComponent();
    }


    private void FrmReservation_Load(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        ReservationService reservationService = new ReservationService();
        dgvReservation.DataSource = reservationService.GetReservationList();
        List<Models.Customer> resList = customerService.GetCustomerList();
        cmbCustomer.DataSource = resList;
        cmbCustomer.ValueMember = "Id";
        cmbCustomer.DisplayMember = "FullName";
        dtpRes_Date.Value = DateTime.Now;
    }


    private void btnDelete_Click(object sender, EventArgs e)
    {
        int customerId = cmbCustomer.SelectedIndex;
        ReservationService reservationService = new ReservationService();
        Models.Reservation reservation = reservationService.GetReservationByCustomerId(customerId);
        if (reservation != null)
        {
            reservationService.DeleteReservation(reservation.Id);
            MessageBox.Show("Rezervasyon başarıyla silindi.");
        }
        else
        {
            MessageBox.Show("Seçilen müşteriye ait bir rezervasyon bulunamadı.");
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        ReservationService reservationService = new ReservationService();
        Models.Reservation reservation = reservationService.GetReservationByCustomerId(cmbCustomer.SelectedIndex);
        if (reservation != null)
        {
            reservation.ReservationDate = dtpRes_Date.Value;
            reservation.CustomerId = (int)cmbCustomer.SelectedValue;
            reservationService.UpdateReservation(reservation);
        }
    }


    private void dgvReservation_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
        RestaurantContext db = new RestaurantContext();
        int id = (int)dgvReservation.CurrentRow.Cells[4].Value;
        Models.Reservation reservation = db.Reservations.Where(x => x.Id == id).FirstOrDefault();
        if (reservation != null)
        {
            cmbCustomer.SelectedValue = reservation.CustomerId;
            dtpRes_Date.Value = reservation.ReservationDate;
        }
    }

    private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbCustomer.SelectedItem != null)
        {
            Models.Customer selectedCustomer = (Models.Customer)cmbCustomer.SelectedItem;
            int selectedCustomerId = selectedCustomer.Id;

            ReservationService reservationService = new ReservationService();
            Models.Reservation value = reservationService.GetReservationByCustomerId(selectedCustomerId);

            if (value != null)
            {
                dtpRes_Date.Value = value.ReservationDate;
            }
            else
            {
                MessageBox.Show("Seçilen müşteriye ait rezervasyon kaydı bulunamadı.");
            }
        }
    }
}
