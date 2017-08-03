using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

[ServiceContract(Namespace = "http://www.stepuptransfor.com/Example/2009/03/wcf")]
public interface IHelloWcfService
{
    [OperationContract]
    string SayHello(string msg);
}

namespace HelloWcfClientConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello Wcf Client Console Application";
            IHelloWcfService Proxy = ChannelFactory<IHelloWcfService>.CreateChannel(
                new NetTcpBinding(),
                new EndpointAddress(
                    "net.tcp://localhost:9000/HelloWcfExpPoiint"));
            while(true)
            {
                Console.WriteLine("Enter text and hit return: ");
                    string msg =Console.ReadLine();
                string result=Proxy.SayHello(msg);
                Console.WriteLine("Server returned: " + result);
            }
        }

        }
    }


