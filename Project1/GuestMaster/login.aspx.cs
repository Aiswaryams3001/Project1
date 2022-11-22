using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.GuestMaster
{
    public partial class login : System.Web.UI.Page
    {
        BAL.Project1BAL objpjtbl = new BAL.Project1BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objpjtbl.User_username = txtuname.Text;
            objpjtbl.userpassword = txtpassword.Text;
            DataTable dt = objpjtbl.LoginCheck();
            if(dt.Rows.Count ==1)
            {
                Session["UserName"] = dt.Rows[0]["username"].ToString();
                Session["userid"] = dt.Rows[0]["userid"].ToString();
                if (dt.Rows[0]["role"].ToString().Trim() == "Admin")
                {
                    Response.Redirect("../admin/Default.aspx");
                }
                else if (dt.Rows[0]["role"].ToString() == "user")
                {
                    if (dt.Rows[0]["status"].ToString() == "confirmed")
                    {
                        Response.Redirect("../User/user.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Wait for the Confirmation');</script>");
                    }
                }
            }
        }
    }
}
