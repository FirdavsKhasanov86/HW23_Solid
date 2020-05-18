using System;
using System.Collections.Generic;
using System.Text;

namespace HW23_Solid.OpenClosedPrinciple
{
    public class IEmployeeReport
    {
         // Метод для создания отчета
        public virtual void GenerateReport(Employee em)
        {
            // Базовая реализация, которую нельзя модифицировать
        }
    }

    public class EmployeeCSVReport : IEmployeeReport
    {
        public override void GenerateReport(Employee em)
        {
            // Генерация отчета в формате CSV
        }
    }

    public class EmployeePDFReport : IEmployeeReport
    {
        public override void GenerateReport(Employee em)
        {
            // Генерация отчета в формате PDF
        }
    }
}
