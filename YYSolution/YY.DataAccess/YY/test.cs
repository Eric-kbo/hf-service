using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using YY.DataModel;
using YY.DataModel.YY;

namespace YY.DataAccess.YY
{
    public class test
    {
        public string GetData()
        {
            string sql = @"select * from test_person where 1=@id";
            MySqlParameter[] paras = new MySqlParameter[]
                {
                    new MySqlParameter("@id","1")
                };

            IList<testEntity> taList = new List<testEntity>();

            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.connectionString, CommandType.Text, sql, paras);

            taList = IListDataSetHelper.DataSetToIList<testEntity>(ds, 0);
            return JsonHelper.ObjectToJsonString(taList);
        }
    }
}
