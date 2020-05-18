using System;
using System.Collections.Generic;
using System.Text;

namespace HW23_Solid.InterfaceSegregationPrinciple
{
    public interface IOperationAdd
    {
        bool AddDetailsEmployee();
    }

    public interface IOperationGet
    {
        bool ShowDetailsEmployee(int id);
    }
}
