
using Assign01EFCore.DbContexts;
using Assign01EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Assign01EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region CRUD
            #region Insert
            Student student1 = new Student() { FName = "Ali", LName = "Mohamed", Address = "Cairo", Age = 22, DepartmentId = 3 };
            Student student2 = new Student() { FName = "Sara", LName = "Ahmed", Address = "Alexandria", Age = 20, DepartmentId = 5 };

            //dbContext.Students.AddRange(student1, student2);
            //dbContext.SaveChanges();

            ////var department1 = new Department
            ////{
            ////    Name = "Computer Science",
            ////    HiringDate = new DateOnly(2020, 1, 15),

            //};
            //var department1 = new Department
            //{
            //    Name = "Computer Science",
            //    HiringDate = new DateOnly(2020, 1, 15),
            //    ManagerId = 3
            //};
            //dbContext.Departments.Add(department1);
            //dbContext.SaveChanges();

            Course course1 = new Course() { Name = "Software Engineering", Duration = 45, Description = "Software development methodologies.", TopicId = 1 };
            //dbContext.Courses.Add(course1);
            //dbContext.SaveChanges();


            

            //var Instructor1 = new Instructor
            //{
            //    Name = "Dr. Mohamed",
            //    Salary = 5000m,
            //    Bouns = 1500m,
            //    Address = "Alexandria",
            //    HourRate = 200m,
            //    DepartmentId = 3
            //};

            //dbContext.Instructors.Add(Instructor1);
            //dbContext.SaveChanges();


            //var Topic1 = new Topic
            //{
            //    Name = "Machine Learning"
            //};

            //dbContext.Topics.Add(Topic1);
            //dbContext.SaveChanges();


            //var instructorCourse = new InstructorCourse
            //{
            //    InstructorId = 1,  
            //    CourseId = 1,      
            //    Evaluation = "Excellent"
            //};

            //dbContext.Set<InstructorCourse>().Add(instructorCourse);
            //dbContext.SaveChanges();


            #endregion



            #endregion

            #region EagerLoading
            //var MyInstructor = dbContext.Instructors
            //    .Include(i => i.InstructorCourses) 
            //    .FirstOrDefault(i => i.Id == 1);

            //if (MyInstructor != null)
            //{
            //    Console.WriteLine($"Name : {MyInstructor.Name}");
            //    foreach (var course in MyInstructor.InstructorCourses)
            //    {
            //        Console.WriteLine($"Course: {course.c}");
            //    }
            //}
            #endregion


        }
    }
}
