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

namespace EF_RestaurantReservation.Forms.Menu;
public partial class FrmMenu : Form
{
    public FrmMenu()
    {
        InitializeComponent();
    }

    private void FrmMenu_Load(object sender, EventArgs e)
    {
        MenuService menuService = new MenuService();
        dtGridMenuList.DataSource = menuService.GetAllMenu();
    }

    private void dtGridMenuList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dtGridMenuList.CurrentRow.Cells[3].Value);
        RestaurantContext db = new RestaurantContext();
        MenuService menuService = new MenuService();
        Models.Menu menu = menuService.GetMenuById(id);
        if (menu != null)
        {
            txtDescription.Text = menu.Description;
            txtPrice.Text = menu.Price.ToString();
            txtTitle.Text = menu.Title;
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MenuService menuService = new MenuService();
        int id = Convert.ToInt32(dtGridMenuList.CurrentRow.Cells[3].Value);
        menuService.DeleteMenu(id);
        dtGridMenuList.DataSource = menuService.GetAllMenu();

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        MenuService menuService=new MenuService();
        Models.Menu menu=new Models.Menu();
        menu.Title = txtTitle.Text;
        menu.Description = txtDescription.Text;
        menu.Price=Convert.ToDecimal(txtPrice.Text);
        menu.Id = Convert.ToInt32(dtGridMenuList.CurrentRow.Cells[3].Value);
        menuService.UpdateMenu(menu);
        dtGridMenuList.DataSource=menuService.GetAllMenu();
    }
}
