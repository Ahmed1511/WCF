using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeWCFService
{    
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddEmployyeeRecord(Employee emp);

        [OperationContract]
        DataSet GetEmployeeRecords();

        [OperationContract]
        string DeleteRecords(Employee emp);

        [OperationContract]
        DataSet SearchEmployeeRecord(Employee emp);

        [OperationContract]
        string UpdateEmployeeContact(Employee emp);

    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public string EmpID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Gender { get; set; }
    }


    
    
    
}
