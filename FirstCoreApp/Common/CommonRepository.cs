using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstCoreModelApi.Common;
namespace FirstCoreApp.Common
{
    public class CommonRepository:DbContext
    {

        public CommonRepository(DbContextOptions<CommonRepository> options) : base(options)
        {

        }
        public DbSet<Books> books { get; set; }
    }
}
