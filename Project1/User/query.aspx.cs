using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.User
{
    public partial class Query : System.Web.UI.Page
    {
        BAL.QueryBAL objprdtbl = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                productname_bind();
            }
        }
        public void productname_bind()
        {
            DataTable prod = objprdtbl.ProductValues();
            DropDownList2.DataSource = objprdtbl.ProductValues();
            DropDownList2.DataTextField = "productname";
            DropDownList2.DataValueField = "productname";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("-- Select --", "0"));
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            
            objprdtbl.productid = Convert.ToInt32(DropDownList2.SelectedIndex);
            objprdtbl.userid = Convert.ToInt32(Session["userid"]);
            objprdtbl.qryrply = null;
            objprdtbl.qrymsg = qrymsg.Text;
            int i = objprdtbl.Query_reg();
            if (i == 1)
            {
                Response.Write("<script>alert('Query Registered Successfully');</script>");
            }
        }
    }
}