using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XieChengAPI.Database
{
    public class AddDbContext:DbContext
    {

        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {

        }

        //public DbSet<TouristRoute> TouristRoutes { get; set; }

        //public DbSet<TouristRoutePicture> TouristRoutes { get; set; }
    }
}
