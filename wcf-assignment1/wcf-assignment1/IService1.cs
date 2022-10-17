using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here
        [OperationContract]
        string FindPrime(int num);
        [OperationContract]
        string SumDigits(string num);
        [OperationContract]
        string ReverseString(string str);
        [OperationContract]
        string PrintHTMLTAG(string tag, string data);
        [OperationContract]
        string SortNumbers(string sortType, string fiveNumbers);
    }


   
}
