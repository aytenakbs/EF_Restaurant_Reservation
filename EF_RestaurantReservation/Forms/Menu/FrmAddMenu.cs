
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
using EF_RestaurantReservation.Models;

namespace EF_RestaurantReservation.Forms.Menu;
public partial class FrmAddMenu : Form
{
    public FrmAddMenu()
    {
        InitializeComponent();
    }

    private void FrmAddMenu_Load(object sender, EventArgs e)
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
            txtTitle.Text = menu.Title;
            txtPrice.Text=menu.Price.ToString();
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        RestaurantContext db=new RestaurantContext();
        MenuService menuService=new MenuService();
        Models.Menu menu=new Models.Menu();
        menu.Title=txtTitle.Text;
        menu.Price=Convert.ToDecimal(txtPrice.Text);
        menu.Description=txtDescription.Text;
        menuService.AddMenu(menu);
        dtGridMenuList.DataSource=menuService.GetAllMenu();
    }
}
