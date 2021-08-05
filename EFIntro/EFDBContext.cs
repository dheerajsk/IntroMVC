using EFIntro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFIntro
{
    public class EFDBContext : DbContext
    {

        public EFDBContext(DbContextOptions<EFDBContext> options): base(options)
        {

        }
        
        public DbSet<Teacher> Teacher { get; set; }
    }
}
