using Microsoft.EntityFrameworkCore;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Persistence
{
    public class MMTDbContext : DbContext, IApplicationDbContext
    {
        public MMTDbContext(DbContextOptions<MMTDbContext> options) : base(options) { }

        public DbSet<Dinner> Dinners => throw new NotImplementedException();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        //public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    return await base.SaveChangesAsync(cancellationToken);
        //}
    }
}
