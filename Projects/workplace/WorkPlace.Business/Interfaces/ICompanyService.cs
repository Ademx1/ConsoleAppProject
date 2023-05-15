using System;
using WorkPlace.Core.Entities;

namespace WorkPlace.Business.Interfaces
{
	public interface ICompanyService
	{
		void Create(string name);
		void Delete(string name);
		Company GetById(int id);
		List<Company> GetAll();
	}
}

