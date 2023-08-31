using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test_NETFRAMEWORK_
{
    public partial class UserDB : DbContext
    {
        public UserDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInfo> UsersInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasOptional(e => e.UsersInfo)
                .WithRequired(e => e.Users);
        }
    }
}
