using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WebApplication1.Models;


namespace Food
{
    
    public class BusinessLogic
    {
        public static void AddOrder(string user,string foodname,string size,string pepper,string chilli, string ketchup, string tartar)
        {
            FoodOrders entities = new FoodOrders();
            FoodListTable order = new FoodListTable();
            order.UserName = user;
            order.Food = foodname;
            order.SizeOfMeal = size;
            order.Pepper = pepper;
            order.Chilli = chilli;
            order.Ketchup = ketchup;
            order.Tartar = tartar;
            entities.FoodListTables.Add(order);
            entities.SaveChanges();
        }
    }
}