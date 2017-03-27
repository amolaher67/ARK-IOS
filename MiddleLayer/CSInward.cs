using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBLayer;
using System.Data;
using System.Windows.Forms;

namespace MiddleLayer
{
    public class CSInward
    {
        DBLayer.CommonDBClass obj;
        private long _GrnNo;
        private String _BillNo;
        private DateTime _BillDate;
        private DateTime _InwardDate;
        private string _SupName;
        private string _BillType;
        private string _MaterialType;
        private String _PONO;
        private Double _Total;
        private string _InwardNumber;
        

     //Inward item varial

        private String _MaterialName;
        private String _MaterialUnit;
        private Double _Material_qty;
        private Double _Material_Amount;
        private Double _Material_rate;
        private String _Material_machine;

        public String MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

        public double Material_rate
        {
            get { return _Material_rate; }
            set { _Material_rate = value; }
        }
       

        public double Material_Amount
        {
            get { return _Material_Amount; }
            set { _Material_Amount = value; }
        }
       

        public String Material_machine
        {
            get { return _Material_machine; }
            set { _Material_machine = value; }
        }

        public Double Material_qty
        {
            get { return _Material_qty; }
            set { _Material_qty = value; }
        }
        public String MaterialUnit
        {
            get { return _MaterialUnit; }
            set { _MaterialUnit = value; }
        }

        public Double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

   //Set Properties for all members of Inward Class     
        public long GrnNo
        {
            get { return _GrnNo; }
            set { _GrnNo = value; }
        }
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }
        
        public DateTime BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }
       

        public DateTime InwardDate
        {
            get { return _InwardDate; }
            set { _InwardDate = value; }
        }
        

        public string SupName
        {
            get { return _SupName; }
            set { _SupName = value; }
        }
       

        public string BillType
        {
            get { return _BillType; }
            set { _BillType = value; }
        }
       

        public string MaterialType
        {
            get { return _MaterialType; }
            set { _MaterialType = value; }
        }
   

        public String PONO
        {
            get { return _PONO; }
            set { _PONO = value; }
        }
        private String _PODate;

        public String PODate
        {
            get { return _PODate; }
            set { _PODate = value; }
        }

        public string InwardNumber
        {
            get
            {
                return _InwardNumber;
            }

            set
            {
                _InwardNumber = value;
            }
        }


        //Next Code Is used to get All Supplier From Databse and return dataset of that

        public DataTable ChkBillPresent()
        {
            obj = new CommonDBClass();
            return obj.Executer("SELECT * FROM inward where bill_no='"+_BillNo+"' and sup_name='"+_SupName+"' " );
        }
        
        public DataTable getSupplier()
        {
             obj = new CommonDBClass();
            return obj.Executer("SELECT DISTINCT sup_name FROM inward");
        }

        public DataTable getMaterialType()
        {
            obj = new CommonDBClass();
            return obj.Executer("SELECT DISTINCT material_type FROM inward");
        
        }
        //this function get next no of grn
        public long getMax()
        {
            obj = new CommonDBClass();
            return obj.FindMax("Inward","inward_no");
        }

        public string  getMaxNumber()
        {
            using (obj = new CommonDBClass())
            {
                return obj.FindMax("Inward", "Inwardnumber");
            }
        }
        public void FillList(ListBox list, TextBox txt, string str, string dispmem,int table_name)
        {
            DBInward obj = new DBInward();
            obj.FillList(list, txt, str, dispmem, table_name);
        }
  
        //Function which saves the information of inward

        public void saveInward()
        {
            DBInward obj = new DBInward();
            obj.saveInward(_GrnNo,_InwardDate,_SupName,_BillNo,_BillDate,_BillType,_MaterialType,_PONO,_PODate,_Total);
        }

        //this function used for Save inward item

        public void save_Inward_Item()
        {
            DBInward obj = new DBInward();
            obj.SaveInwardItem(_GrnNo, _MaterialName.ToUpperInvariant(), _MaterialUnit, _Material_qty, _Material_rate, _Material_Amount, _Material_machine.ToUpperInvariant());
       
        }
        //fuction for updating inward
        public void UpdateInward()
        {
            DBInward obj = new DBInward();
            obj.UpdateInward(_GrnNo, _InwardDate, _SupName, _BillNo, _BillDate, _BillType, _MaterialType, _PONO, _PODate, _Total);
        }

        //For Deleting Inward Items
        public void DeleteInwardItem()
        {
            DBInward obj = new DBInward();
            obj.DeleteInwardItem(_GrnNo);
        }

        //For Deleting Inward  
        public void DeleteInward()
        {
            DBInward obj = new DBInward();
            obj.DeleteInward(_GrnNo);
        }
        //functiom for searching data datewise
        public DataTable search(DateTime dt1, DateTime dt2,int flag)
        {
             DBInward obj = new DBInward();
             return obj.search( dt1, dt2,flag);
        }

        //overload search function for machinewiase search
        public DataTable search(String input,DateTime dt1,DateTime dt2,int flag)
        {
            DBInward obj = new DBInward();
            return obj.search(input, dt1, dt2, flag);
        }
        public DataTable FillMachine()
        {
            DBInward obj = new DBInward();
           return obj.FillMachine1(); 
        }
        public DataTable GetAllUnit()
        {
            DBInward obj = new DBInward();
            return obj.FillUnits(); 
        }
        public DataTable GetInward()
        {
            DBInward obj = new DBInward();
            return obj.GetInward(_GrnNo);
  
        }

        public DataTable GetInwardItem()
        {
            DBInward obj = new DBInward();
            return obj.GetInwardItem(_GrnNo);

        }
        public void AddNewMaterial(String Name)
        {
            DBInward obj = new DBInward();
            obj.AddNewMaterial(Name); 

        }

    }
}
