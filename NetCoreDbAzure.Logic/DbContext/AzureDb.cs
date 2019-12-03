using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDbAzure.Logic
{
    public class AzureDb : DbContext
    {
        public AzureDb(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}
