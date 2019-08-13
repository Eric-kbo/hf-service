using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac.DataModel.user
{
    public class userEntity
    {
        public dynamic uid { get; set; }
        public dynamic openid { get; set; }
        public dynamic name { get; set; }
        public dynamic nickName { get; set; }
        public dynamic gender { get; set; }
        public dynamic province { get; set; }
        public dynamic city { get; set; }
        public dynamic country { get; set; }
        public dynamic lang { get; set; }
        public dynamic session_key { get; set; }
        public dynamic pwd { get; set; }
    }
}
