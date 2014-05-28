using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class DbActions
    {
        public static DataTable RunSql(string sql)
        {
            DataTable dt = null;
            try
            {
                //var dBprovider = new DBprovider();
                //dt = dBprovider.ExecuteQuery(sql);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
