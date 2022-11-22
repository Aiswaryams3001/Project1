using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project1.BAL
{
    public class QueryBAL
    {
        DAL.QueryDAL objprdtdl = new DAL.QueryDAL();
        public int _queryid;
        public int _productid;
        public string _productname;
        public int _userid;
        private string _qrymsg;
        private string _qryrply;


        public int queryid
        {
            get
            {
                return _queryid;
            }
            set
            {
                _queryid = value;
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
        public string qrymsg
        {
            get
            {
                return _qrymsg;
            }
            set
            {
                _qrymsg = value;
            }
        }
        public string qryrply
        {
            get
            {
                return _qryrply;
            }
            set
            {
                _qryrply = value;
            }
        }
        public int Query_reg()
        {
            return objprdtdl.Query_Reg(this);
        }
        public DataTable ProductValues()
        {
            return objprdtdl.Product_list();
        }
        public DataTable UsersList()
        {
            return objprdtdl.users_list();
        }
        public DataTable viewQuery()
        {
            return objprdtdl.view_query(this);
        }
        public int updateStatus()
        {
            return objprdtdl.Update_Reply(this);
        }
        public DataTable userViewQueryStatus()
        {
            return objprdtdl.user_view_querystatus(this);
        }
    }
}