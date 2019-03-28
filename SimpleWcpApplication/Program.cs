using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                WebServiceHost host = new WebServiceHost(typeof(MyService), new Uri("http://localhost:9595"));
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IMyService), new WebHttpBinding(), "");
                ServiceDebugBehavior stp = host.Description.Behaviors.Find<ServiceDebugBehavior>();
                stp.HttpHelpPageEnabled = false;
                host.Open();
                Console.WriteLine("Service is up and running");
                Console.WriteLine("Press enter to quit ");
                Console.ReadLine();
                host.Close();
            }
            catch(Exception e)
            {
                File.WriteAllText("C:\\Error.txt", e.ToString());
            }
        }
    }
}
