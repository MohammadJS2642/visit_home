using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VisitHomeApi.Models;

namespace VisitHomeApi.Data
{
    public partial class VisitHomeContext : DbContext
    {
        public VisitHomeContext()
        {
        }

        public VisitHomeContext(DbContextOptions<VisitHomeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Home> Homes { get; set; }

    }
}
