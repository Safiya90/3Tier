using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Tier.BLL.Interfaces;
using _3Tier.DAL.Context;
using _3Tier.DAL.Entities;

namespace _3Tier.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Add(T entity)
         => _context.Set<T>().Add(entity);

        public void DeleteById(T entity)
         => _context.Set<T>().Remove(entity);


        public IEnumerable<T> GetAll()
         => _context.Set<T>().ToList();


        public T GetById(int id)
        => _context.Set<T>().Find(id);

        public void Update(T entity)
        => _context.Set<T>().Update(entity);


    }
}
