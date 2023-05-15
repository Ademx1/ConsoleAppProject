using System;
using WorkPlace.Business.DTOs.EmployeeDTO;
using WorkPlace.Core.Entities;

namespace WorkPlace.Business.Interfaces;

public interface IEmployeeService
{
	void Create(EmployeeCreateDTO employeeCreateDto);
	void Delete(int id);
	void EmployeeTransfer(int id, string departmentName);
	void Update(int id, EmployeeCreateDTO employeeCreateDTO);
	void UpdateEmployeeSalary(int id, double salary);
	List<Employee> GetAll(int skip, int take);
	List<Employee> GetEmployeesByName(string name);
	Employee GetEmployeeById(int id);
		 
}

