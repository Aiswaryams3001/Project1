using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Project1.DAL;

namespace Project1.BAL
{
    public class Project1BAL
    {
        DAL.Project1DAL objdeptdl = new DAL.Project1DAL();
        private string Id;
        private string name;
        private string email;
        private string address;
        private string date;
        private string username;
        private string password;
        public object _lid;
        public string user_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string userId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string user_email
        {
            get
            { return email; }
            set { email = value; }
        }
        public string user_address
        {
            get { return address; }
            set { address = value; }
        }
        public string user_date
        {
            get { return date; }
            set { date = value; }
        }
        public object lid
        {
            get { return _lid; }
            set { _lid = value; }
        }
        public string User_username { get { return username; } set { username = value; } }
        public string userpassword { get { return password; } set { password = value; } }

        public object user_login_insert()
        { return objdeptdl.userlogin(this); }
        public int user_reg() { return objdeptdl.user_Registration(this); }
        public DataTable Viewusers() { return objdeptdl.view_users(); }

        public int confirmuser()
        {
            return objdeptdl.Confirm_user(this);
        }
        public DataTable LoginCheck()
        {
             return objdeptdl.usercheck(this);
        }

    }
}