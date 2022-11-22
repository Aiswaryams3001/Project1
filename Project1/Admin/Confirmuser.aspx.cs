using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project1.BAL;

namespace Project1.Admin
{
    public partial class Confirmuser : System.Web.UI.Page
    {
        BAL.Project1BAL objdeptdl = new BAL.Project1BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdeptdl.Viewusers();
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s =GridView1.DataKeys[e.RowIndex].Value.ToString();

            objdeptdl.userId = s;

            int i = objdeptdl.confirmuser();
            GridView1.DataSource = objdeptdl.Viewusers();
            GridView1.DataBind();
        }
    }
}