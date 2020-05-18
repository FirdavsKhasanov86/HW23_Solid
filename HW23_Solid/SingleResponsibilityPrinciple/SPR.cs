using System;
using System.Collections.Generic;
using System.Text;

namespace HW23_Solid.SingleResponsibilityPrinciple
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        
        // Данный метод добавляет в БД нового сотрудника
        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }
    }

    public class EmployeeReport
    {
        // Отчет по сотруднику
        public void GenerateReport(Employee em)
        {
            // Генерация отчета по деятельности сотрудника
        }
    }
}
