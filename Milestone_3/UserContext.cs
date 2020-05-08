using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.SqlServer;


using Milestone_3.Models.Categories;
using Milestone_3.Models.Goods;
using Milestone_3.Models.Users;
using Milestone_3.Models.Comments;


namespace Milestone_3.Models
{
    public class UserContext : DbContext
    {
        public UserContext()
        {
        }

        /*
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
   optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = GoodsDatabase;Integrated Security = True");

}*/

        public UserContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
    

    }
}
