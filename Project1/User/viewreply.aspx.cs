using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.User
{
    public partial class viewreply : System.Web.UI.Page
    {
        BAL.QueryBAL objprdtbl = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objprdtbl.userid = Convert.ToInt32(Session["userid"].ToString());
                GridView1.DataSource = objprdtbl.userViewQueryStatus();
                GridView1.DataBind();
            }
        }
    }
}