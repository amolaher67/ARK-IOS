using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Management;


namespace InwardDetails
{
    public enum Type
    {
        QueryType,
        NonQueryType
    }
    public enum Record
    {
        Save,
        Update
    }

    class DBClass
    {

        SqlConnection con;
        SqlDataReader dr;
        
        public DBClass()
        {
            string ss1 = ConfigurationManager.ConnectionStrings["DBConnString"].ToString();
            con = new SqlConnection(ss1);
        }

        public SqlDataReader Executer(SqlCommand cmd, Type type)
        {
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            cmd.Connection = con;


            cmd.CommandType = CommandType.StoredProcedure;
            if (type == Type.NonQueryType)
            {
                cmd.ExecuteNonQuery();
            }
            if (type == Type.QueryType)
            {
                dr = cmd.ExecuteReader();
            }
            return dr;
        }

        public SqlDataAdapter Executer(SqlCommand temp)
        {
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            temp.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(temp);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            return da;

        }
        public DataTable Executer(string Querystr)
        {
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(Querystr, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Executer(string ProcName,int flag,String Condition)                                                                         //-----------------------------------Datatable(Procedure name, Flag,Condition)                                                                    
        {
            SqlCommand cmd;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            cmd = new SqlCommand(ProcName);
            cmd.Parameters.Add(new SqlParameter("flag",flag));
            if(Condition.Trim()!=String.Empty)
                cmd.Parameters.Add(new SqlParameter("Condition","%"+ Condition+"%"));
            else
                cmd.Parameters.Add(new SqlParameter("Condition", Condition + "%"));
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
           da.Fill(dt);
                     return dt;
        }


        public void Delete(String ProcName,long id,int flag,String Condition)
        {

            SqlCommand cmd = new SqlCommand(ProcName);
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.Parameters.Add(new SqlParameter("id",id));
            cmd.Parameters.Add(new SqlParameter("Condition", Condition));
             cmd.ExecuteNonQuery();                                                                                                                         
        }

        public long FindSelected(string temp)
        {
            long max = 0;
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(temp, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    max = (Convert.ToInt64((dr[0])));
                }
            }
            return max;
        }




        public long FindMax(string table, String column)                                                    //----------------------------------Get max id
        {
            long max = 0;

            String query = "SELECT MAX(" + column + ") FROM " + table;
            try
            {
                if ("Open" == con.State.ToString())
                    con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];
                max = Convert.ToInt64(dr[0]);
            }
            catch (Exception)
            {
            }

            return max + 1;
        }







        public DataTable GetInfo(int flag,string Tablename, String cnd1,String cnd2,String Attribute)                                                                         //-----------------------------------Datatable(Procedure name, Flag,Condition)                                                                    
        {
            SqlCommand cmd;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            cmd = new SqlCommand("GetInfo");
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("flag", flag));
            cmd.Parameters.Add(new SqlParameter("Tablename", Tablename));
            cmd.Parameters.Add(new SqlParameter("cnd1", cnd1));
            cmd.Parameters.Add(new SqlParameter("cnd2", cnd2));
            cmd.Parameters.Add(new SqlParameter("Attribute", Attribute));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        public void Delete(String Tablename,long id,String Attribute)
        {

            SqlCommand cmd = new SqlCommand("Delete_Entry");
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("tablename", Tablename));
            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("Attribute", Attribute));
            cmd.ExecuteNonQuery();
        }


        public long AddVillage(string vlg_name, long tal_id)                                                    //----------------------------------Get max id
        {
            long max = 0;
            if ("Open" == con.State.ToString())
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select  ISNULL(MAX(vlg_id),0)+1 from village", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    max = (Convert.ToInt64((dr[0])));
                }
            }
            String query = "insert into village (vlg_id,vlg_name,tal_id) values (" + max + ",'" + vlg_name + "'," + tal_id + ")";
            try
            {
                if ("Open" == con.State.ToString())
                    con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            return max;
        }

        public long FindMax(string temp)
        {
            long max = 1;
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(temp, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    max = (Convert.ToInt64((dr[0])) + 1);
                }
            }
            dr.Dispose();
            con.Close();
            return max;
        }

    }
}










