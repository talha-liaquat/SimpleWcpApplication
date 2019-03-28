using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcpApplication
{
    [ServiceContract]
    public interface IMyService
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string Hello(string name);
    }
}
