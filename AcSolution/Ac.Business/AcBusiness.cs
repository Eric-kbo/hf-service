using Ac.DataAccess.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac.Business
{
    public class AcBusiness
    {
        public string GetData()
        {
            test dao = new test();
            return dao.GetData();
        }
    }
}
