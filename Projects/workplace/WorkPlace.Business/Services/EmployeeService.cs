using System;
using WorkPlace.Business.DTOs;
using WorkPlace.Business.Exceptions;
using WorkPlace.Business.Helpers;
using WorkPlace.Business.Interfaces;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Implementations;


namespace WorkPlace.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeeRepository { get; }
    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();
    }

    public void Create(EmployeeDto employee)
    {
        if (employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);

        }
        if (employee.salary < 300)
        {
            throw new MinimumSalaryException(Helper.errors["MinimumSalaryExceotion"]);

        }
        if (employee.name.Length < 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);

        }
        if (employee.name.IsOnlyLetter() && employee.surname.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);

        }
        Employee emp = new Employee(employee.salary, employee.name, employee.surname, employee.departmentId);
        if (!employeeRepository.GetAll().Contains(emp))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        employeeRepository.Add(emp);

    }

    public void Remove(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = employeeRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        employeeRepository.Delete(result);
    }

    public void Update(int id, EmployeeDto employee)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        var result = new Employee(employee.salary, employee.name, employee.surname, employee.departmentId);
        if (employeeRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        employeeRepository.Update(id, result);
    }


    public Employee GetById(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = employeeRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Employee GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = employeeRepository.GetByName(name);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public List<Employee> GetAll()
    {
        var result = employeeRepository.GetAll();
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

}
