using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWcfServiceLibrary
{
    public class HelloWcfService : IHelloWcfService
    {
        public string SayHello(string msg)
        {
            Console.WriteLine("Received from Client:" + msg);
            return String.Format("You entered: {0} - Time{1}", msg, DateTime.Now);
        }
    }
}
