using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DBLayer
{
    public class DBFinicialYear
    {
        CommonDBClass obj;
        SqlCommand cmd;

        public bool saveFinicialYear(String FinicialYear)
        {
            try
            {
                obj = new CommonDBClass();
                cmd = new SqlCommand("InsertOrUpdate_FinicialYear");
                cmd.CommandType = CommandType.StoredProcedure;
                var res = obj.Executer(cmd, Type.NonQueryType);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool setFinicialYear(int finicialYearID)
        {
            try
            {
                obj = new CommonDBClass();
                cmd = new SqlCommand("InsertOrUpdate_FinicialYear");
                cmd.Parameters.Add(new SqlParameter("FinicialYearID", finicialYearID));
                cmd.Parameters.Add(new SqlParameter("IsActive", true));
                cmd.CommandType = CommandType.StoredProcedure;
                var res = obj.Executer(cmd, Type.NonQueryType);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
