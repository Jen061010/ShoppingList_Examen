using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UsersContext:DbContext,IUnitOfWork,IDbContext
    {
        public UsersContext ()
            :base("DefaultConnection")
	    {

	    }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
