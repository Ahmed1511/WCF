using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SWCC.WCFEmployee
{
    
    public class Service1 : IEmployee
    {
        public string CreateOrUpdate(Emplyee emplyee)
        {
           
                using (SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SWCCEmployeeWCFTask;Data Source=DESKTOP-SGAMSH1"))
                {
                if (emplyee.EmpId == null)
                {
                    SqlCommand cmd = new SqlCommand();
                    string Query = @"INSERT INTO tblEmployee (EmpID,ArName,EnName,ParentCode,IsActivated,LastModeficationDate)  
                                                   Values(@EmpID,@ArName,@EnName,@ParentCode,@IsActivated,@LastModeficationDate)";

                    cmd = new SqlCommand(Query, con);
                    emplyee.EmpId = "1";
                    cmd.Parameters.AddWithValue("@EmpID", emplyee.EmpId);
                    cmd.Parameters.AddWithValue("@ArName", emplyee.ArName);
                    cmd.Parameters.AddWithValue("@EnName", emplyee.EnName);
                    cmd.Parameters.AddWithValue("@ParentCode", emplyee.ParentCode);
                    cmd.Parameters.AddWithValue("@IsActivated", emplyee.IsActivated);
                    cmd.Parameters.AddWithValue("@LastModeficationDate",emplyee.LastModefiedDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //con.Close();
                    return "Record Added Successfully !";
                }
                
                else
                {
                    SqlCommand cmd = new SqlCommand();

                    string Query = "UPDATE tblEmployee SET EmpID=@EmpID,ArName=@ArName,EnName=@EnName,ParentCode=@ParentCode,IsActivated=@IsActivated,LastModeficationDate=@LastModeficationDate  WHERE EmpID=@EmpID";

                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@EmpID", emplyee.EmpId);
                    cmd.Parameters.AddWithValue("@ArName", emplyee.ArName);
                    cmd.Parameters.AddWithValue("@EnName", emplyee.EnName);
                    cmd.Parameters.AddWithValue("@ParentCode", emplyee.ParentCode);
                    cmd.Parameters.AddWithValue("@IsActivated", emplyee.IsActivated);
                    cmd.Parameters.AddWithValue("@LastModeficationDate", emplyee.LastModefiedDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return "Record Update Successfully !";
                   
                }
            }
        }
    }
}
