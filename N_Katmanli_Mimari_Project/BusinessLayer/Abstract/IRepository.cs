using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IRepository<T> where T : class, new()
	{
		Task<List<T>> GetAll();
		Task Insert(T entity);
		Task Delete(T entity);
		Task Update(T entity);
		Task<T> GetByID(int id);
	}
}
