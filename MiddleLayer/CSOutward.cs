using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBLayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleLayer
{
    public class CSOutward
    {
        DBOutward obj;
        private int _IssueNo;
        private String _IssueTo;
        private String _Unit;
        private DateTime _IssueDate;
        private String _Material_Name;
        private String _MachineName;
        private Double _Qty;
        private Double _Issue;
             
       
        public int IssueNo
        {
            get { return _IssueNo; }
            set { _IssueNo = value; }
        }
        

        public String IssueTo
        {
            get { return _IssueTo; }
            set { _IssueTo = value; }
        }

        public String Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        public DateTime IssueDate
        {
            get { return _IssueDate; }
            set { _IssueDate = value; }
        }
        
        public String Material_Name
        {
            get { return _Material_Name; }
            set { _Material_Name = value; }
        }
        
        public String MachineName
        {
            get { return _MachineName; }
            set { _MachineName = value; }
        }

        public Double Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public Double Issue
        {
            get { return _Issue; }
            set { _Issue = value; }
        }
        
        public void FillList(ListBox list, TextBox txt, string str, string dispmem, int table_name)
        {
            DBOutward obj = new DBOutward();
            obj.FillList(list, txt, str, dispmem, table_name);
        }
        //public DataTable FetchMaterialList(string name)
        //{
        //    obj = new DBOutward();
        //    return obj.FetchMaterialList(name);
      // f }

        public void SaveOutward()
        {
             obj = new DBOutward();
            obj.SaveOutWard(_IssueNo, _IssueTo, _IssueDate);
        }

        public void SaveOutwardItem()
        {
             obj = new DBOutward();
             obj.SaveOutWardItem(_IssueNo,_Material_Name, _MachineName,_Qty,_Issue);
        }

        public void UpdateOutward()
        {
            obj = new DBOutward();
            obj.UpdateOutward(_IssueNo, _IssueTo, _IssueDate);
        }

       
        public DataTable LoadNames()
        {
             obj = new DBOutward();
            return obj.LoadNames();

        }
        public long getMax()
        {
            CommonDBClass obj = new CommonDBClass();
            return obj.FindMax("Outward", "IssueNo");
        }
      
        //functiom for searching data datewise
        public DataTable search(DateTime dt1, DateTime dt2)
        {
            DBOutward obj = new DBOutward();
            return obj.search(dt1, dt2);
        }

        //overload search function for machinewiase search
        public DataTable search(String input, DateTime dt1, DateTime dt2,int flag)
        {
             obj = new DBOutward();
             return obj.search(input, dt1, dt2,flag);
        }

        public DataTable DislayStock(int flag)
        {
             obj = new DBOutward();
             return obj.getStock(_Material_Name,flag);
        }

        public DataTable FillMaterial()
        {
            obj = new DBOutward();
            return obj.FillMaterial();
        }


        public void DeleteOutward()
        {
            obj = new DBOutward();
            obj.DeleteOutward(_IssueNo);
           
        }

        public void DeleteOutwardItem()
        {
            obj = new DBOutward();
            obj.DeleteOutwardItem(_IssueNo);
        }

        public DataTable getOutWard()
        {
            obj = new DBOutward();
           return obj.getOutward(_IssueNo);
        }
        public DataTable getOutWardItem()
        {
            obj = new DBOutward();
            return obj.getOutwardItem(_IssueNo);
        }
        public DataTable FillMachine()
        {
            DBInward obj = new DBInward();
            return obj.FillMachine();
        }

        
    }
}
