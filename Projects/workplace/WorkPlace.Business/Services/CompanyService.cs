using System;
using WorkPlace.Business.DTOs;
using WorkPlace.Business.Exceptions;
using WorkPlace.Business.Helpers;
using WorkPlace.Business.Interfaces;
using WorkPlace.Core.Entities;
using WorkPlace.DataAccess.Implementations;

namespace WorkPlace.Business.Services;

public class CompanyService:ICompanyService
{
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }

    public void Create(CompanyDto company)
    {
        if (company == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }

        if (company.name.Length < 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (company.name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        Company comp = new Company(company.name);
        if (!companyRepository.GetAll().Contains(comp))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        companyRepository.Add(comp);
    }

    public void Remove(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = companyRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        companyRepository.Delete(result);
    }

    public void Update(int id, CompanyDto employee)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if (employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        var result = new Company(employee.name);
        if (companyRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        companyRepository.Update(id, result);
    }



    public Company GetById(int id)
    {
        if (id < 0)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        var result = companyRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Company GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = companyRepository.GetByName(name);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }


    public List<Company> GetAll()
    {
        var result = companyRepository.GetAll();
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }
}

