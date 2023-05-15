using System;
using WorkPlace.Core.Entities;

namespace WorkPlace.Business.Interfaces
{
	public interface IDepartmentService
	{
		void Create(string departmentName, string companyName, int employeeLimit);
		void Delete(int departmentId,string departmentName);
		void UpdateDepartment(string newname, int employeeLimit);
		Department GetById(int id);
		Department GetByName(string departmentName);
		List<Department> GetAll();
	}
}



