using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Abstract
{
	public class GenericRepository<T> : IRepository<T> where T : class, new()
	{
		public async Task Delete(T entity)
		{
			using (var context = new N_Katmanli_MimariDbContext())
			{
				context.Remove(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task<List<T>> GetAll()
		{
			using (var context = new N_Katmanli_MimariDbContext())
			{
				return await context.Set<T>().ToListAsync();
			}
		}

		public async Task<T> GetByID(int id)
		{
			using (var context = new N_Katmanli_MimariDbContext())
			{
				var entity = await context.Set<T>().FindAsync(id);
				return entity;
			}
		}

		public async Task Insert(T entity)
		{
			using (var context = new N_Katmanli_MimariDbContext())
			{
				await context.AddAsync(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task Update(T entity)
		{
			using (var context = new N_Katmanli_MimariDbContext()) 
			{
				context.Update(entity);
				await context.SaveChangesAsync();
			}
		}
	}
}
