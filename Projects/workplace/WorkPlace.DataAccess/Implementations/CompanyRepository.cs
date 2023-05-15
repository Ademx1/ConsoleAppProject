using System;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Contexts;
using WorkPlace.DataAccess.Interfaces;

namespace WorkPlace.DataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{

    public void Add(Company entity)
    {
        DBContext.Companies.Add(entity);
    }

    public void Delete(Company entity)
    {
        DBContext.Companies.Remove(entity);
    }

    public void Update(int id, Company entity)
    {
        var findedEntity = DBContext.Companies.Find(comp => comp.CompanyId == id);

        findedEntity.CompanyName = entity.CompanyName;
    }

    public Company? GetById(int id)
    {
        return DBContext.Companies.Find(comp => comp.CompanyId == id);
    }

    public Company? GetByName(string name)
    {
        return DBContext.Companies.Find(comp => comp.CompanyName == name);
    }


    public List<Company>? GetAll()
    {
        return DBContext.Companies;
    }
}

