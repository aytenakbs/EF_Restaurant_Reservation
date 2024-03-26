using EF_RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_RestaurantReservation.Services;
public class MenuService
{
    public List<Menu> GetAllMenu()
    {
        RestaurantContext db = new RestaurantContext();
        List<Menu> menuList =db.Menus.ToList();
        return menuList;
    }
    public void AddMenu(Menu menu)
    {
        RestaurantContext db=new RestaurantContext();
        db.Menus.Add(menu);
        db.SaveChanges();
    }
    public void DeleteMenu(int id)
    {
        RestaurantContext db = new RestaurantContext();
        Menu menu=GetMenuById(id);
        db.Menus.Remove(menu);
        db.SaveChanges();
    }
    public Menu GetMenuById(int id)
    {
        RestaurantContext db=new RestaurantContext();
        Menu menu=db.Menus.FirstOrDefault(y=>y.Id==id);
        return menu;
    }
    public void UpdateMenu(Menu menu)
    {
        RestaurantContext db=new RestaurantContext();
        Menu value=db.Menus.FirstOrDefault(x=>x.Id==menu.Id);
        if (value != null)
        {
            value.Id = menu.Id;
            value.Title = menu.Title;
            value.Description = menu.Description;
            value.Price = menu.Price;
        }
        db.Menus.Update(value);
        db.SaveChanges();
    }
}
