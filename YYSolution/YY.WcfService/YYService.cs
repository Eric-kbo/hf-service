using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.Business;
using YY.IWcfService;

namespace YY.WcfService
{
    public class YYService : IYYService
    {
        public string GetData()
        {
            YYBusiness yb = new YYBusiness();
            return yb.GetData();
        }

        public string GetString()
        {
            return "hello";
        }
    }
}
