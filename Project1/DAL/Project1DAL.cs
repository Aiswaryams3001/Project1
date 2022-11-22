using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class Project1DAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Project1DAL()
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
        public object userlogin(BAL.Project1BAL obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + obj.User_username + "','" + obj.userpassword + "','Not confirmed','user');select @@IDENTITY";

            object id = cmd.ExecuteScalar();
            return id;

        }
        public int user_Registration(BAL.Project1BAL obj)
        {
            string s = "insert into Registration values('"+obj.user_name+"','"+obj.user_email+"','"+obj.user_address+"','" + obj.user_date + "','" + obj.lid + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
            }

        //internal DataTable view_users()
        //{
            //throw new NotImplementedException();
        //}
        public DataTable view_users() 
        {
            string qry = "select s.*,l.* from Registration s inner join login l on s.lid=l.lid where l.status='Not confirmed' and role='user'";


            SqlCommand cmd = new SqlCommand(qry, Getcon()); 
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            return dt; 
        }
        public int Confirm_user(BAL.Project1BAL obj) 
        { 
            string s = "update login set status='confirmed' where lid=" + obj.userId + ""; 
            SqlCommand cmd = new SqlCommand(s, Getcon()); 
            return cmd.ExecuteNonQuery(); 
        }
        public DataTable usercheck(BAL.Project1BAL obj)
        {
            //string qry="SELECT * FROM login WHERE username='"+obj.User_username+"' AND password='"+obj.userpassword+"'";
            string qry = "select s.*,l.* from Registration s inner join login l on s.lid=l.lid  WHERE username='"+obj.User_username+"' AND password='"+obj.userpassword+"'";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}