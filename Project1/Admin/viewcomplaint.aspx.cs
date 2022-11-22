using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.Admin
{
    public partial class viewcomplaint : System.Web.UI.Page
    {
        BAL.ComplaintBAL objprdtbl = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtbl.viewComplaints();
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtbl.viewComplaints();
            GridView1.DataBind();
        }



        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            objprdtbl.complaintid = id;
            objprdtbl.cmpsts = txt.Text;
            int i = objprdtbl.updateStatus();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtbl.viewComplaints();
            GridView1.DataBind();
        }

    }
}