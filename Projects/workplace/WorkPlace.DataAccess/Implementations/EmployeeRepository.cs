using System;
using WorkPlace.DataAccess.Interfaces;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Contexts;

namespace WorkPlace.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
      DBContext.Employees.Add(entity);
    }

    public void Delete(int id)
    {
        var employee = DBContext.Employees.Find(emp=>emp.EmployeeId==id);
        DBContext.Employees.Remove(employee);
    }

    public void Update(Employee entity)
    {
        var employee = DBContext.Employees.Find(emp => emp.EmployeeId == entity.EmployeeId);
        employee.Salary = entity.Salary;
        employee.EmployeeName = entity.EmployeeName;
        employee.EmployeeSurname = entity.EmployeeSurname;

    }

    public Employee GetById(int id)
    {
       return  DBContext.Employees.Find(emp => emp.EmployeeId == id);
    }

    public List<Employee> GetAllByName(string name)
    {
        return DBContext.Employees.FindAll(emp => emp.EmployeeName == name);
    }

    public List<Employee> GetAll(int skip, int take)
    {
        return DBContext.Employees.GetRange(skip, take);    
    }

}

