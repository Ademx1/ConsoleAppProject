using System;
using WorkPlace.Business.DTOs;
using WorkPlace.Business.Exceptions;
using WorkPlace.Business.Helpers;
using WorkPlace.Business.Interfaces;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Implementations;

namespace WorkPlace.Business.Services;

public class DepartmentService : IDepartmentService
{

    public DepartmentRepository departmentRepository { get; }
    public EmployeeRepository employeeRepository { get; }
    public DepartmentService()
    {
        departmentRepository = new DepartmentRepository();
        employeeRepository = new EmployeeRepository();
    }

    public void Create(DepartmentDto department)
    {
        if (department == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        if (department.employeeLimit < 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (department.name.Length < 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (department.name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        if (department.companyId < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }

        if (employeeRepository.GetAll().Count < department.employeeLimit)
        {
            throw new EmployeeLimitException(Helper.errors["EmployeeLimitException"]);
        }
        Department dep = new Department(department.name, department.employeeLimit, department.companyId);
        if (!departmentRepository.GetAll().Contains(dep))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        departmentRepository.Add(dep);
    }

    public void Remove(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = departmentRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        departmentRepository.Delete(result);
    }

    public void Update(int id, DepartmentDto department)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (department == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        if (employeeRepository.GetAll().Count < department.employeeLimit)
        {
            throw new EmployeeLimitException(Helper.errors["EmployeeLimitException"]);
        }
        var result = new Department(department.name, department.employeeLimit, department.companyId);
        if (departmentRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        departmentRepository.Update(id, result);
    }

    public Department GetById(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = departmentRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Department GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = departmentRepository.GetByName(name);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }



     public List<Department> GetAll()
    {
        var result = departmentRepository.GetAll();
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }
}

