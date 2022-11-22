using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.Admin
{
    public partial class viewquery : System.Web.UI.Page
    {
        BAL.QueryBAL objprdtbl = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtbl.viewQuery();
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtbl.viewQuery();
            GridView1.DataBind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            objprdtbl.queryid = id;
            objprdtbl.qryrply = txt.Text;
            int i = objprdtbl.updateStatus();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtbl.viewQuery();
            GridView1.DataBind();
        }
    }
}