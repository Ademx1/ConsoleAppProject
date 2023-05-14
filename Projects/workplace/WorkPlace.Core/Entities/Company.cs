using System;
namespace WorkPlace.Core.Entities;

public class Company
{
    private static int _count = 1;
    public int Id { get; }
    public string CompanyName { get; set; }

    public Company()
    {
        Id = _count;
        _count++; 
    } 
    public Company(string companyName):this()
    { 
       CompanyName = companyName;
    }
    
}