using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.User
{
    public partial class viewcomplaintSts : System.Web.UI.Page
    {
        BAL.ComplaintBAL objprdtbl=new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                objprdtbl.userid = Convert.ToInt32(Session["userid"].ToString());
                GridView1.DataSource = objprdtbl.userViewComplaint();
                GridView1.DataBind();
            }
        }
    }
}