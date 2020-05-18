using System;
using System.Collections.Generic;
using System.Text;

namespace HW23_Solid.LiskovSubstitutionPrinciple
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IWork
    {
        string GetWorkDetails(int employeeId);
    }

    public class SeniorEmployee : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }

    public class JuniorEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }
}
