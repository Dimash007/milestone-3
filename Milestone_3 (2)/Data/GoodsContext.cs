﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Milestone_3.Models.Goods;
using Milestone_3.Models.Categories;
using Milestone_3.Models.Comments;
using Milestone_3.Models.Users;

namespace Milestone_3.Data
{
    public class GoodsContext : DbContext
    {

        public GoodsContext(DbContextOptions options) : base(options)
        {
        }

      //  public User us = new User("1ab","Ablaihan","Bexeit", "Able777@gmail.com", "able777");
        public DbSet<Good> Goods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Good>().HasData(new Good
            {
                Id = "1aa",
                Name = "Iphone",
                Characteristics = "13 mpx 64 gb",
                Category = new Category(1, "Smartphone"),
                Comments = "Ablaihan"
            },
            new Good
            {
                Id = "2aa",
                Name = "Samsung",
                Characteristics = "16 mpx 128 gb",
                Category = new Category(1, "Smartphone"),
                Comments =  "Ablaihan"
            }
        );
        }

        internal void SaveChanges(Good good)
        {
            throw new NotImplementedException();
        }
    }
}