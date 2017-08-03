using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloWcfServiceLibrary
{
    [ServiceContract(Namespace = "http://www.stepuptransfor.com/Example/2009/03/wcf")]
   public interface IHelloWcfService
    {
        [OperationContract]
        string SayHello(string msg);
    }
}
