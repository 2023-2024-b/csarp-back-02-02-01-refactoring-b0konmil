using Kreata.Backend.Datas;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            List<Parent> parents = new List<Parent>
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Miklós",
                    LastName="Major",
                    BirthDay=new DateTime(2020,10,10),
                    MathersName="Anna",
                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szilveszer",
                    LastName="Szeplős",
                    BirthDay=new DateTime(2011,4,4),
                    MathersName="Szilvia",
                }
            };

            modelBuilder.Entity<Parent>().HasData(parents);

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Béla",
                    LastName="Végh",
                    BirthDay=new DateTime(2000,10,10),
                    MathersName="Balázs",
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Tivadar",
                    LastName="Tapló",
                    BirthDay=new DateTime(2001,4,4),
                    MathersName="Tamás",
                }
            };

            // Teachers
            modelBuilder.Entity<Teacher>().HasData(teachers);
        }
    }
}
