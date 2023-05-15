using System;
using WorkPlace.DataAccess.Interfaces;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Contexts;
using WorkPlace.DataAccess.Contexts;

namespace WorkPlace.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DBContext.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DBContext.Employees.Remove(entity);
    }

    public void Update(int id, Employee entity)
    {
        var findedEntity = DBContext.Employees.Find(emp => emp.EmployeeId == id);

        findedEntity.EmployeeName = entity.EmployeeName;
        findedEntity.EmployeeSurname = entity.EmployeeSurname;
        findedEntity.DepartmentId = entity.DepartmentId;
        findedEntity.Salary = entity.Salary;

    }

    public Employee? GetById(int id)
    {
        return DBContext.Employees.Find(emp => emp.EmployeeId == id);
    }

    public Employee? GetByName(string name)
    {
        return DBContext.Employees.Find(emp => emp.EmployeeName== name);
    }


    
    public List<Employee>? GetAll()
    {
        return DBContext.Employees;
    }
}

