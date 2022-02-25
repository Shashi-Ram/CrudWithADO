using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace CrudWithADO.Models
{
    public class EmployeeDataAccess
    {
        DBConnection Dbconnection;
        public EmployeeDataAccess()
        {
            Dbconnection = new DBConnection();
        }
        public List<Employees> GetEmployees()
        {
            string Sp = "P_Employee";
            SqlCommand sql = new SqlCommand(Sp,Dbconnection.Connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@action", "INNER JOIN");
            if (Dbconnection.Connection.State == ConnectionState.Closed)
            {
                Dbconnection.Connection.Open();
            }
            SqlDataReader dr = sql.ExecuteReader();
            List<Employees> employees = new List<Employees>();
            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Id = (int)dr["id"];
                emp.Name = dr["Ename"].ToString();
                emp.Email = dr["email"].ToString();
                emp.Mobile = dr["mobile"].ToString();
                emp.Gender = dr["Gender"].ToString();
                emp.Dname = dr["Dname"].ToString();
                employees.Add(emp);
            }
            Dbconnection.Connection.Close();
            return employees;
        }
    }
}
