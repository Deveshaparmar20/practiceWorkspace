using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace EmployeeService
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string password)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Users.Any(u =>
                    u.Username.Equals(userName, StringComparison.OrdinalIgnoreCase) && u.Password.Equals((password)));
            }
        }
    }
}