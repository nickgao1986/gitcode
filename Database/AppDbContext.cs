﻿using FakeXiecheng.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using XieChengAPI.Models;

namespace XieChengAPI.Database
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }

        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
         /*   modelbuilder.Entity<TouristRoute>().HasData(new TouristRoute()
            {
                Id = Guid.NewGuid(),
                Title = "ceshititle",
                Description = "shuoming",
                OriginalPrice = 0,
                CreateTime = DateTime.UtcNow
            });*/

            var touristRouteJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutesMockData.json");
            IList<TouristRoute> touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJsonData);
            modelbuilder.Entity<TouristRoute>().HasData(touristRoutes);

            var touristRoutePictureJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutePicturesMockData.json");
            IList<TouristRoutePicture> touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePictureJsonData);
            modelbuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);

            base.OnModelCreating(modelbuilder);
        }
    }
}
