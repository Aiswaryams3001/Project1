using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project1.BAL
{
    public class ComplaintBAL
    {
        DAL.ComplaintDAL objprdtdl = new DAL.ComplaintDAL();
        public int _complaintid;
        public int _productid;
        public string _productname;
        public int _userid;
        private string _cmpmsg;
        private string _cmpsts;
        private string _cmpdate;


        public int complaintid
        {
            get
            {
                return _complaintid;
            }
            set
            {
                _complaintid = value;
            }
        }

        public int productid
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
        public string productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        public int userid
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }
        public string cmpmsg
        {
            get
            {
                return _cmpmsg;
            }
            set
            {
                _cmpmsg = value;
            }
        }
        public string cmpsts
        {
            get
            {
                return _cmpsts;
            }
            set
            {
                _cmpsts = value;
            }
        }
        public string cmpdate
        {
            get
            {
                return _cmpdate;
            }
            set
            {
                _cmpdate = value;
            }
        }
        public int complaint_reg()
        {
            return objprdtdl.complaintReg(this);
        }
        public DataTable viewComplaints()
        {
            return objprdtdl.view_complaints(this);
        }

        public DataTable ProductValues()
        {
            return objprdtdl.Product_list();
        }
        public DataTable UsersList()
        {
            return objprdtdl.users_list();
        }
        public int updateStatus()
        {
            return objprdtdl.Update_Status(this);
        }
    }
}
