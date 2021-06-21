using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task2.Models
{
    public class table
    {
        public int DepartmentName(string name)
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=AdventureWorks2019;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("Select departmentid from HumanResources.department where name='"+name+"'", con);
            con.Open();
            string c = cmd.ExecuteScalar().ToString();
            con.Close();
            return Convert.ToInt32(c);
        }
        public DataTable GetDepartment()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=AdventureWorks2019;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("Select departmentid,name from HumanResources.department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable Display(int Id)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=AdventureWorks2019;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("select per.BusinessEntityID,FirstName,BirthDate,MaritalStatus,Gender,HireDate " +
                "from HumanResources.Employee emp join Person.Person per on emp.BusinessEntityID = per.BusinessEntityID join " +
                "HumanResources.EmployeeDepartmentHistory empdep on per.BusinessEntityID = empdep.BusinessEntityID where DepartmentID ="+Id, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}