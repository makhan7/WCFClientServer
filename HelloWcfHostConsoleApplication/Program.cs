using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloWcfHostConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Hello WCF Host Console Applicaiton";

                using (ServiceHost host = new ServiceHost(typeof(HelloWcfServiceLibrary.HelloWcfService)))
            {
                host.AddServiceEndpoint(typeof(HelloWcfServiceLibrary.IHelloWcfService),
                    new NetTcpBinding(),
                    "net.tcp://localhost:9000/HelloWcfEndPoint");
                host.Open();
               
                Console.ReadLine();
            }
        }
    }
}
