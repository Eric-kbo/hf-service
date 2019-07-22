using Ac.IWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ac.Business;

namespace Ac.WcfService
{
    public class Service : IService
    {
        public string GetData()
        {
            AcBusiness business = new AcBusiness();
            return business.GetData();
        }

        public string GetString()
        {
            return "hello";
        }
    }
}
