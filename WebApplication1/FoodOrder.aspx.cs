using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food;

namespace WebApplication1
{
    public partial class FoodOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessLogic.AddOrder(user.Text, DropDownList1.Text, RadioButtonList1.SelectedValue, (CheckBox1.Checked ? "Y" : "N"), (CheckBox2.Checked ? "Y" : "N"), (CheckBox3.Checked ? "Y" : "N"), (CheckBox4.Checked ? "Y" : "N"));
            
        }

     
    }
}