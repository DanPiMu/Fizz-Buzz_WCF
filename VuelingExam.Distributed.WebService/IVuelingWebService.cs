using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VuelingExam.Distributed.WebService
{
    [ServiceContract]
    public interface IVuelingWebService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "/FizzBuzz/{start}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        List<string> FizzBuzz(string start);
    }


}
