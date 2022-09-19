using Microsoft.EntityFrameworkCore;
using BuberDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<BuberDinner.Domain.Entities.Dinner> Dinners { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
