using System.Collections.Generic;
using VideoRentApp.Models;

namespace VideoRentApp.Interfaces
{
	public interface IRepository<T>
	{
		void Create(T item);
		void Delete(T item);
		void Update(T item);
		T GetById(int id);
		IEnumerable<T> GetList();
	}
}