using WorkPlace.Core.Entities;
namespace WorkPlace.DataAccess.Contexts;


public class DBContext
{
	public static List<Employee> Employees { get; set; } = new();
	public static List<Department> Departments { get; set; } = new();
	public static List<Company> Companies { get; set; } = new();
}

