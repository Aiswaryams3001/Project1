using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class ProductDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public ProductDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int ProductInsert(BAL.ProductBAL obj)
        {
            string qry = "insert into product values('" + obj.ProductName + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable viewProd()
        {
            string s = "select * from product";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Productdelete(BAL.ProductBAL obj)
        {
            string s = "delete from product where productid='" + obj.ProductId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int Productupdate(BAL.ProductBAL obj)
        {
            string s = "update product set productname='" + obj.ProductName + "' where productid='" + obj.ProductId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}