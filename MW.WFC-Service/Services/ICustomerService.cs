using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MW.WFC_Service.Services
{
    public interface ICustomerService
    {
        [OperationContract]
        string GetData(int value);
    }
}
