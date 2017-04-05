using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace DBLayer
{
    public class DBInward
    {
        SqlCommand cmd;
        CommonDBClass obj;
        DataSet ds;
        DataTable dt;

        public void FillList(ListBox list, TextBox txt, string str, string dispmem, int table_name)
        {
            try
            {
                list.DataSource = null;
                list.Items.Clear();
                list.DisplayMember = dispmem;
                list.DataSource = getAllMaterial(str, table_name);
                if (list.Items.Count == 0)
                {
                    list.Visible = false;
                }
                else if (list.Items.Count == 1)
                {
                    if (txt.Text.ToUpper() == list.Text.ToUpper())
                        list.Visible = false;
                    if (txt.Text.ToLower() == list.Text.ToLower())
                        list.Visible = false;
                    else
                        list.Visible = true;
                }
                else
                    list.Visible = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);//The Application encountered an error while attempting to fill the List", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This 
        public DataTable getAllMaterial(String str, int table_name)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();

            cmd = new SqlCommand("GetAccountInfo");
            cmd.Parameters.Add(new SqlParameter("str", str));
            cmd.Parameters.Add(new SqlParameter("table_name", table_name));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;

        }

        //This function used to save inward 
        public long saveInward(long grn_no, DateTime inward_date, String sup, String bill_no, DateTime billdate, String billtype, String material_type, String pono, DateTime? podate, Double Total, string inwardNumber, int finicialYearID)
        {

            obj = new CommonDBClass();
            cmd = new SqlCommand("Insert_Inward");
            cmd.Parameters.Add(new SqlParameter("grn_no", grn_no)).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("sup", sup));
            cmd.Parameters.Add(new SqlParameter("inward_date", inward_date));
            cmd.Parameters.Add(new SqlParameter("bill_no", bill_no));
            cmd.Parameters.Add(new SqlParameter("billdate", billdate));
            cmd.Parameters.Add(new SqlParameter("billtype", billtype));
            cmd.Parameters.Add(new SqlParameter("material_type", material_type));
            cmd.Parameters.Add(new SqlParameter("pono", pono));
            cmd.Parameters.Add(new SqlParameter("podate", podate));
            cmd.Parameters.Add(new SqlParameter("Total", Total));

            cmd.Parameters.Add(new SqlParameter("inwardNumber", inwardNumber));
            cmd.Parameters.Add(new SqlParameter("finicialYearID", finicialYearID));

            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
           
            var val=cmd.Parameters["grn_no"].Value;

            return Convert.ToInt64(val);
   
        }
        //function for updating record

        public void UpdateInward(long grn_no, DateTime inward_date, String sup, String bill_no, DateTime billdate, String billtype, String material_type, String pono, DateTime? podate, Double Total)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("Update_Inward");
            cmd.Parameters.Add(new SqlParameter("grn_no", grn_no));
            cmd.Parameters.Add(new SqlParameter("sup", sup));
            cmd.Parameters.Add(new SqlParameter("inward_date", inward_date));
            cmd.Parameters.Add(new SqlParameter("bill_no", bill_no));
            cmd.Parameters.Add(new SqlParameter("billdate", billdate));
            cmd.Parameters.Add(new SqlParameter("billtype", billtype));
            cmd.Parameters.Add(new SqlParameter("material_type", material_type));
            cmd.Parameters.Add(new SqlParameter("pono", pono));
            cmd.Parameters.Add(new SqlParameter("podate", podate));
            cmd.Parameters.Add(new SqlParameter("Total", Total));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }

        //This function used fro save Inward Item
        public void SaveInwardItem(long GrnNo, String MaterialName, String MaterialUnit, Double Material_qty, double Material_rate, double Material_Amount, String Material_machine)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("InsertInwardItem");
            cmd.Parameters.Add(new SqlParameter("GrnNo", GrnNo));
            cmd.Parameters.Add(new SqlParameter("MaterialName", MaterialName));
            cmd.Parameters.Add(new SqlParameter("MaterialUnit", MaterialUnit));
            cmd.Parameters.Add(new SqlParameter("Material_qty", Material_qty));
            cmd.Parameters.Add(new SqlParameter("Material_rate", Material_rate));
            cmd.Parameters.Add(new SqlParameter("Material_Amount", Material_Amount));
            cmd.Parameters.Add(new SqlParameter("Material_machine", Material_machine));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }

        //Delete All Items of Inward
        public void DeleteInwardItem(long GrnNo)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("DeleteInwardItem");
            cmd.Parameters.Add(new SqlParameter("GrnNo", GrnNo));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }

        //Delete Inward
        public void DeleteInward(long GrnNo)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("DeleteInward");
            cmd.Parameters.Add(new SqlParameter("GrnNo", GrnNo));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }

        //This fuction is used for searching inward item date wise
        public DataTable search(DateTime dt1, DateTime dt2, int flag)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();
            cmd = new SqlCommand("SerachInward");
            cmd.Parameters.Add(new SqlParameter("dt1", dt1));
            cmd.Parameters.Add(new SqlParameter("dt2", dt2));
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;

        }

        //overload search function here for machine wise search
        //Machine wise beetwwen dates  
        public DataTable search(String mc, DateTime dt1, DateTime dt2, int flag)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();
            cmd = new SqlCommand("SerachInward");

            cmd.Parameters.Add(new SqlParameter("dt1", dt1));
            cmd.Parameters.Add(new SqlParameter("dt2", dt2));
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.Parameters.Add(new SqlParameter("mc", mc));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        public DataTable FillMachine()
        {

            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("SELECT DISTINCT MachineName FROM Outward_Item");
            return dt;
        }
        public DataTable FillMachine1()
        {

            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("SELECT DISTINCT Machine_Name FROM Material_inward_item");
            return dt;
        }

        public DataTable FillUnits()
        {

            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("select distinct Unit_id,unit_name from unit");
            return dt;
        }
        public DataTable GetInward(long grnno)
        {
            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("select * from  inward where inward_no=" + grnno + "  ");
            return dt;
        }
        public DataTable GetInwardItem(long grnno)
        {
            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("select * from  material_inward_item where inward_no=" + grnno + "  ");
            return dt;
        }
        public void AddNewMaterial(String Name)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("AddMaterialName");
            cmd.Parameters.Add(new SqlParameter("MaterialName", Name));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }


    }
}
