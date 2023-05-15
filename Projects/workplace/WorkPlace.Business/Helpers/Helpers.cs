using System;
namespace WorkPlace.Business.Helpers
{
    public static class Helper
    {
        public static Dictionary<string, string> errors = new Dictionary<string, string>()
        {
          {"NullDataException","You must give data" },
          {"MimimumSalaryException","Salary can't be less than minimum income" },
          {"SizeException","Your length doesn't match" },
          {"FormatException","Your data format is incorrect" },
          {"AlreadyExistException","This data already exists on DBContext" },
          {"EmployeeLimitException","You are exceeded the employee limit"}

        };
    }
}

