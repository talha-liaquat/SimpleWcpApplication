using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(MyService), new Uri("http://localhost:9696"));
            var endpoint = host.AddServiceEndpoint(typeof(IMyService), new WebHttpBinding(), "api");
            host.Open();
            Console.Read();
            host.Close();
        }
    }
}
