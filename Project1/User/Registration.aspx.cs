using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project1.BAL;

namespace Project1.User
{
    public partial class Registration : System.Web.UI.Page
    {
        BAL.Project1BAL objpjtbl = new BAL.Project1BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objpjtbl.user_name = txtname.Text;
            objpjtbl.user_email = txtemail.Text;
            objpjtbl.user_address = txtaddress.Text;
            objpjtbl.user_date = txtdate.Text;
            objpjtbl.User_username = txtuname.Text;
            objpjtbl.userpassword = txtpassword.Text;
            object ob = objpjtbl.user_login_insert();
            objpjtbl.lid =Convert.ToInt32(ob);
            int j = objpjtbl.user_reg();
            Response.Write("Your Registration is successful");
        }
    }
}