using System;
using WorkPlace.Business.DTOs;
using WorkPlace.Core.Entities;

namespace WorkPlace.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeDto employee);
    void Remove(int id);
    void Update(int id, EmployeeDto employee);
    List<Employee> GetAll();
    Employee GetById(int id);
    Employee GetByName(string name);

}

