using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBLayer
{
    public class DBOutward
    {
        SqlCommand cmd;
        CommonDBClass obj;
        DataTable dt;
        DataSet ds;
 
        
        public void SaveOutWard(int Id, String IssueTo, DateTime date)
        {
            obj = new CommonDBClass();

            cmd = new SqlCommand("InsertOutwrad");
            cmd.Parameters.Add(new SqlParameter("IssueNo",Id));
            cmd.Parameters.Add(new SqlParameter("IssueTo", IssueTo));
            cmd.Parameters.Add(new SqlParameter("IssueDate", date));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
       }
        public void SaveOutWardItem(int IssueId, String Material, String Machine, Double qty, Double IssueQty)
        {
            obj = new CommonDBClass();

            cmd = new SqlCommand("InsertOutwradItem");
            cmd.Parameters.Add(new SqlParameter("IssueId", IssueId));
            cmd.Parameters.Add(new SqlParameter("Material", Material));
            cmd.Parameters.Add(new SqlParameter("Machine", Machine));
            cmd.Parameters.Add(new SqlParameter("qty",qty));
            cmd.Parameters.Add(new SqlParameter("IssueQty", IssueQty));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }
        public void UpdateOutward(int Id, String IssueTo, DateTime date)
        {
            obj = new CommonDBClass();

            cmd = new SqlCommand("UpdateOutwrad");
            cmd.Parameters.Add(new SqlParameter("IssueNo", Id));
            cmd.Parameters.Add(new SqlParameter("IssueTo", IssueTo));
            cmd.Parameters.Add(new SqlParameter("IssueDate", date));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);
        }


        public DataTable LoadNames()
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();

            cmd = new SqlCommand("GetAccountInfo");
            cmd.Parameters.Add(new SqlParameter("table_name",3));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }


        //This fuction is used for searching inward item date wise

        public DataTable search(DateTime dt1, DateTime dt2)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();
            cmd = new SqlCommand("SerachOutWard");
            cmd.Parameters.Add(new SqlParameter("dt1", dt1));
            cmd.Parameters.Add(new SqlParameter("dt2", dt2));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;

        }

        //overload search function here for machine wise search

        public DataTable search(String mc,DateTime dt1,DateTime dt2,int flag)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();
            cmd = new SqlCommand("SerachOutwardMachineWise");
            cmd.Parameters.Add(new SqlParameter("mc", mc));
            cmd.Parameters.Add(new SqlParameter("dt1", dt1));
            cmd.Parameters.Add(new SqlParameter("dt2", dt2));
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        public DataTable getStock(String Material,int flag)
        {
            obj = new CommonDBClass();
            dt = new DataTable();
            ds = new DataSet();
            cmd = new SqlCommand("Stock");
            cmd.Parameters.Add(new SqlParameter("material_name",Material));
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = obj.Executer(cmd);
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                return dt;
            }
            else
                return null;
        }
        public DataTable FillMaterial()
        {

            dt = new DataTable();
            obj = new CommonDBClass();
            string q = @"SELECT     material_inward_item.material_name, inward.bill_type, material_inward_item.machine_name
                         FROM inward INNER JOIN
                         material_inward_item ON inward.inward_no = material_inward_item.inward_no
                         WHERE (inward.bill_type <> 'Labour') AND (material_inward_item.machine_name = 'STORE')";

            dt = obj.Executer(q);
            return dt;
        }
        public void DeleteOutward(long Outno)
           {
             obj = new CommonDBClass();
             cmd = new SqlCommand("DeleteOutward");
             cmd.Parameters.Add(new SqlParameter("OutNo", Outno));
             cmd.CommandType = CommandType.StoredProcedure;
             obj.Executer(cmd, Type.NonQueryType);
              
        }
        public void DeleteOutwardItem(long Outno)
        {
            obj = new CommonDBClass();
            cmd = new SqlCommand("DeleteOutwardItem");
            cmd.Parameters.Add(new SqlParameter("OutNo", Outno));
            cmd.CommandType = CommandType.StoredProcedure;
            obj.Executer(cmd, Type.NonQueryType);


        }


        public DataTable getOutward( long IssueNo)
        {
            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("select * from outward where issueno="+IssueNo+" ");
            return dt;
        }
        public DataTable getOutwardItem(long IssueNo)
        {
            dt = new DataTable();
            obj = new CommonDBClass();
            dt = obj.Executer("select * from outward_item where issueno=" + IssueNo + " ");
            return dt;
        }


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
//        public DataTable FetchMaterialList(string name)
//        {
//                    string query = @"SELECT material_inward_item.material_name, material_inward_item.machine_name
//                                    FROM         inward INNER JOIN
//                                     material_inward_item ON inward.inward_no = material_inward_item.inward_no
//                                     WHERE     (material_inward_item.machine_name = 'STORE'and material_inward_item.material_name like '"+name+"' )";

//                    dt = new DataTable();
//                    obj = new CommonDBClass();
//                    dt = obj.Executer(query);
//                    return dt;
        
//        }

    }
}
