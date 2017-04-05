using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MiddleLayer
{
    public class CSFinicialYear
    {
        DBLayer.CommonDBClass obj;

        private long _FinicialYearId;
        private string _FinicialYearText;
        private DateTime _isActive;

        public long FinicialYearId
        {
            get { return _FinicialYearId; }
            set { _FinicialYearId = value; }
        }

        public DateTime IsActive
        {
            get
            {
                return _isActive;
            }

            set
            {
                _isActive = value;
            }
        }

        public string FinicialYearText
        {
            get
            {
                return _FinicialYearText;
            }

            set
            {
                _FinicialYearText = value;
            }
        }

        public DataTable getAllFinicialYears()
        {
            try
            {
                obj = new CommonDBClass();
                return obj.Executer("SELECT DISTINCT * FROM FinicialYears");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaveFinicialYear(string startMonth, string endMonth)
        {
            DBFinicialYear obj = new DBFinicialYear();
            string finicialYear = "1 " + startMonth + " to 31 " + endMonth;
            return obj.saveFinicialYear(finicialYear);
        }

        public bool SetCurrentFinicialYear(int finicialYearID)
        {
            DBFinicialYear obj = new DBFinicialYear();
            return obj.setFinicialYear(finicialYearID);
        }

    }
}
