using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class QueryDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public QueryDAL()
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
        public DataTable Product_list()
        {
            string qry = "select  * from product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public int Query_Reg(BAL.QueryBAL obj)
        {
            string s = "insert into query  values('" + obj.qrymsg + "','" + obj.productid + "','" + obj.userid + "','Query Received')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable users_list()
        {
            string qry = "select  * from Registration";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public DataTable view_query(BAL.QueryBAL obj)
        {
            string qry = "select  c.queryid,c.userid, p.productid,p.productname,u.name, c.query, c.reply from Product p  INNER JOIN query c  ON p.productid = c.productid INNER JOIN Registration u ON c.userid = u.userid";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Update_Reply(BAL.QueryBAL obj)
        {
            string s = "update query  set reply='" + obj.qryrply + "' where queryid='" + obj.queryid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable user_view_querystatus(BAL.QueryBAL obj)
        {
            string qry = "select c.queryid, p.productid,p.productname,u.name, c.query, c.reply from product p  INNER JOIN query c  ON p.productid = c.productid INNER JOIN Registration u ON u.userid = c.userid AND c.userid ='" + obj.userid + "'";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}