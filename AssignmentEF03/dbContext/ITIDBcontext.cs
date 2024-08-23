using AssignmentEF03.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF03.dbContext
{
    public class ITIDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-5Q5HCPF ; DataBase = ITI ; Trusted_Connection = True ; Encrypt = False");
        }


        public DbSet<Students> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Course_Inst> Course_Insts { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
               .HasKey(SC => new { SC.Course_ID, SC.Stud_ID });
               

            modelBuilder.Entity<Course_Inst>()
                .HasKey(CI => new { CI.Course_ID, CI.inst_ID });

            modelBuilder.Entity<Course_Inst>()
              .HasOne(ci => ci.Course)
              .WithMany(c => c.Course_Insts)
              .HasForeignKey(ci => ci.Course_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Insts)
                .HasForeignKey(ci => ci.inst_ID);


            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.Stud_ID);

        }
    }

    
}
