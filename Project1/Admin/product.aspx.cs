using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.Admin
{
    public partial class product : System.Web.UI.Page
    {
        BAL.ProductBAL objprdtbl = new BAL.ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtbl.viewProduct();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprdtbl.ProductName = txtproductname.Text;
            int i = objprdtbl.insertProduct();
            GridView1.DataSource = objprdtbl.viewProduct();
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtbl.viewProduct();
            GridView1.DataBind();
        }
        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprdtbl.ProductId = id.ToString();
            int i = objprdtbl.Deleteproduct();
            GridView1.DataSource=objprdtbl.viewProduct();
            GridView1.DataBind();
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];

            objprdtbl.ProductId = id.ToString();
            objprdtbl.ProductName = txt.Text;
            int i = objprdtbl.updateproduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtbl.viewProduct();
            GridView1.DataBind();
        }
        protected void GridView1_RowCancelingEdit(object sender,GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtbl.viewProduct();
            GridView1.DataBind();
        }
    }
}