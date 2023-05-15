using System;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Interfaces;
using WorkPlace.DataAccess.Contexts;

namespace WorkPlace.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DBContext.Departments.Add(entity);
    }

    public void Delete(Department entity)
    {
        DBContext.Departments.Remove(entity);
    }

    public void Update(int id, Department entity)
    {
        var findedEntity = DBContext.Departments.Find(dep => dep.DepartmentId == id);

        findedEntity.DepartmentName = entity.DepartmentName;
        findedEntity.EmployeeLimit = entity.EmployeeLimit;
        findedEntity.CompanyId = entity.CompanyId;

    }

    public Department? GetById(int id)
    {
        return DBContext.Departments.Find(dep => dep.DepartmentId == id);
    }

    public Department? GetByName(string name)
    {
        return DBContext.Departments.Find(dep => dep.DepartmentName == name);
    }

    public List<Department>? GetAll()
    {
        return DBContext.Departments;
    }
}

