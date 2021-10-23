using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SWCC.WCFEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        string CreateOrUpdate(Emplyee emplyee);
    }


    [DataContract]
    public class Emplyee
    {
        [DataMember]
        public string EmpId { get; set; }
        [DataMember]
        public string ArName { get; set; }
        [DataMember]
        public string EnName { get; set; }
        [DataMember]
        public string ParentCode { get; set; }
        [DataMember]
        public bool IsActivated { get; set; }
        [DataMember]
        public DateTime LastModefiedDate { get; set; }
    }
}
