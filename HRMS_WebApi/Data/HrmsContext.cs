using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMS_WebApi.Models;

namespace HRMS_WebApi.Data
{
    public class HrmsContext : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<Site> Site { get; set; }

        public HrmsContext(DbContextOptions<HrmsContext> options) 
            : base(options)  {   }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //em => Entity Menu
            modelBuilder.Entity<Menu>(em =>
            {
                em.HasKey(param => param.MenuID);
                em.Property(param => param.MenuID).HasColumnType("varchar(4)");
                em.Property(param => param.MenuGroup).HasColumnType("varchar(2)");
                em.Property(param => param.MenuNameEng).HasColumnType("varchar(100)");
                em.Property(param => param.MenuNameTh).HasColumnType("varchar(100)");
                em.Property(param => param.ControllerID).HasColumnType("varchar(200)");
                em.Property(param => param.CreateBy).HasColumnType("varchar(50)");
                em.Property(param => param.CreateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
                em.Property(param => param.UpdateBy).HasColumnType("varchar(50)");
                em.Property(param => param.UpdateDate).HasColumnType("datetime")
                    .HasDefaultValueSql<DateTime>("SYSDATETIME()");
            });

            //er => Entity Role
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

            //erm => Entity RoleMenu
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

            //es => Entity Site
            modelBuilder.Entity<Site>(es =>
            {
                es.Property(param => param.SiteId).HasColumnType("varchar(3)");
                es.Property(param => param.SiteName).HasColumnType("varchar(200)");
                es.Property(param => param.BillDay).HasColumnType("tinyint");
                es.Property(param => param.CustomerCode).HasColumnType("varchar(200)");
                es.Property(param => param.WelcomeMessage).HasColumnType("varchar(1000)");
                es.Property(param => param.WarningMessage).HasColumnType("varchar(500)");
                es.Property(param => param.WarningTimes).HasColumnType("varchar(30)");
                es.Property(param => param.ExtendTime).HasColumnType("tinyint");
                es.Property(param => param.LoginLockTimes).HasColumnType("tinyint");
            });
        }
    }
}
