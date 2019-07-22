using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Ac.DataModel;
using Ac.DataModel.user;

namespace Ac.DataAccess.test
{
    public class test
    {
        public string GetData()
        {
            string sql = @"select * from hf_user where 1=@i";
            MySqlParameter[] paras = new MySqlParameter[]
                {
                    new MySqlParameter("@i","1")
                };

            IList<userEntity> taList = new List<userEntity>();

            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.connectionString, CommandType.Text, sql, paras);

            taList = IListDataSetHelper.DataSetToIList<userEntity>(ds, 0);
            return JsonHelper.ObjectToJsonString(taList);
        }
    }
}
