using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac.DataModel.user
{
    public class userEntity
    {
        public int uid { get; set; }
        public string openid { get; set; }
        public string name { get; set; }
        public string nickName { get; set; }
        public int gender { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string lang { get; set; }
        public string session_key { get; set; }
        public string pwd { get; set; }
    }
}
