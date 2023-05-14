using System;
using WorkPlace.Core.Interfaces;

namespace WorkPlace.Core.Entities;

public class Employee : IEntity
{
    private static int _count = 1;
    public int EmployeeId { get; }
    public decimal Salary { get; set; }
    public string EmployeeName { get; }
    public string EmployeeSurname { get; }
    public int DepartmentId { get; set; }
   
    public Employee(string employeeName, string employeeSurname, decimal salary)
    {
        EmployeeId = _count;
        _count++;
        EmployeeName = employeeName;
        EmployeeSurname = employeeSurname;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{EmployeeId}, {EmployeeName}, {EmployeeSurname}";
    }
}

