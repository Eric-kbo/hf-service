using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YY.DataAccess;
using YY.DataAccess.YY;

namespace YY.Business
{
    public class YYBusiness
    {
        public string GetData()
        {
            test dao = new test();
            return dao.GetData();
        }
    }
}
