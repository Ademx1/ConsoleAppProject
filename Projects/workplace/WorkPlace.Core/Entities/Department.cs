using System;
using WorkPlace.Core.Interfaces;

namespace WorkPlace.Core.Entities;

public class Department : IEntity
{
    private static int _count = 1;
    public int DepartmentId { get; }
    public string DepartmentName { get; set; }
    public int EmployeeLimit { get; set; }
    public int CompanyId { get; set; }

    public Department()
    {
        DepartmentId = _count;
        _count++;
    }

    public Department(string departmentName, int employeeLimit,int companyId)
    {
        DepartmentName = departmentName;
        EmployeeLimit = employeeLimit;
        CompanyId = companyId;
    }

    public override string ToString()
    {
        return $"{DepartmentName}, Id- {DepartmentId}";
    }






}
