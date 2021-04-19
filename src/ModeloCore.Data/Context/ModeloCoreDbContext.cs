using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloCore.Data.Context
{
    public class ModeloCoreDbContext : DbContext
    {
        public ModeloCoreDbContext(DbContextOptions<ModeloCoreDbContext> options) : base(options)
        {

        }
    }
}
