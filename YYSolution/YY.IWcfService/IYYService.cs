﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace YY.IWcfService
{
    [ServiceContract]
    public interface IYYService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetData", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetString", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string GetString();

    }
}
