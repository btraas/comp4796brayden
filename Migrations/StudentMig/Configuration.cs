namespace StudentAPI.Migrations.StudentMig
{
    using StudentAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentMig";
        }

        protected override void Seed(StudentAPI.Models.ApplicationDbContext context)
        {

            context.students.AddOrUpdate(
                 new Student { StudentId = "A00957203", FirstName = "Yudhvir", LastName ="Raj", Program="CST" },
                 new Student { StudentId = "A00957202", FirstName = "Jason", LastName = "Sekhon", Program = "CST" },
                 new Student { StudentId = "A00957209", FirstName = "Julia", LastName = "Kummins", Program = "Nursing" }
                 );
            context.SaveChanges();
        }
    }
}
