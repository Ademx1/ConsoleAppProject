using WorkPlace.Business.DTOs;
using WorkPlace.Business.Services;
using WorkPlace.Business.DTOs;
using WorkPlace.Business.Services;



EmployeeService empservice = new EmployeeService();
DepartmentService depservice = new DepartmentService();
CompanyService compservice = new CompanyService();
EmployeeDto empdto = new EmployeeDto(12300, "Kamran", "Jabiyev", 001);
DepartmentDto depdto = new DepartmentDto("Head Department", 18, 137);
CompanyDto compdto = new CompanyDto("Code Company");




empservice.Create(empdto);
depservice.Create(depdto);
compservice.Create(compdto);