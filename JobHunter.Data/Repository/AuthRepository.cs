using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobHunter.Data.Entities;
using JobHunter.Data.Interfaces;

namespace JobHunter.Data.Repository
{
    public class AuthRepository : IRepository<AppUser>
    {
        private readonly ApplicationDbContext _context;

        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public AppUser Create(AppUser entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public async Task<AppUser> Get(Expression<Func<AppUser, bool>> predicate)
        {
            var user = await _context.Users.Where(predicate).FirstOrDefaultAsync();

            if (user == null)
                return null;

            return user;
        }
    }
}
