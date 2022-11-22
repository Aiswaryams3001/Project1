using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project1.BAL
{
    public class ProductBAL
    {
        DAL.ProductDAL objdeptdl = new DAL.ProductDAL();

        private string _productName;
        private string _productid;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }
        public int insertProduct()
        {
            return objdeptdl.ProductInsert(this);
        }
        public DataTable viewProduct()
        {
            return objdeptdl.viewProd();
        }
        public int Deleteproduct()
        {
            return objdeptdl.Productdelete(this);
        }
        public int updateproduct()
        {
            return objdeptdl.Productupdate(this);
        }
    }
}