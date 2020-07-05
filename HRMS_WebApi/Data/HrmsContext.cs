using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMS_ClassLib.DomainModels;

namespace HRMS_WebApi.Data
{
    public class HrmsContext : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }

        public HrmsContext(DbContextOptions<HrmsContext> options) 
            : base(options)  {   }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(em =>
            {
                em.HasKey(param => param.MenuID);
                em.Property(param => param.MenuID).HasColumnType("varchar(4)");
                em.Property(param => param.MenuGroup).HasColumnType("varchar(2)");
                em.Property(param => param.MenuNameEng).HasColumnType("varchar(100)");
                em.Property(param => param.MenuNameTh).HasColumnType("varchar(100)");
                em.Property(param => param.Controller).HasColumnType("varchar(200)");
                em.Property(param => param.Action).HasColumnType("varchar(200)");
                em.Property(param => param.CreateBy).HasColumnType("varchar(50)");
                em.Property(param => param.CreateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
                em.Property(param => param.UpdateBy).HasColumnType("varchar(50)");
                em.Property(param => param.UpdateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
            });

            modelBuilder.Entity<Role>(er =>
            {
                er.HasKey(param => param.RoleId);
                er.Property(param => param.RoleId).HasColumnType("varchar(2)");
                er.Property(param => param.RoleName).HasColumnType("nchar(10)");
                er.Property(param => param.CreateBy).HasColumnType("varchar(50)");
                er.Property(param => param.CreateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
                er.Property(param => param.UpdateBy).HasColumnType("varchar(50)");
                er.Property(param => param.UpdateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
            });

            modelBuilder.Entity<RoleMenu>(erm =>
            {
                erm.HasKey(param => new { param.RoleId, param.MenuId });
                erm.HasOne<Menu>(param => param.Menu)
                    .WithMany(param => param.RoleMenu)
                    .HasForeignKey(param => param.MenuId);
                erm.HasOne<Role>(param => param.Role)
                    .WithMany(param => param.RoleMenu)
                    .HasForeignKey(param => param.RoleId);
                erm.Property(param => param.CreateBy).HasColumnType("varchar(50)");
                erm.Property(param => param.CreateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
                erm.Property(param => param.UpdateBy).HasColumnType("varchar(50)");
                erm.Property(param => param.UpdateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
            });
        }
    }
}
