using ExamAPP.Models;
using ExamAPP.Models.Mahmoud;
using Microsoft.EntityFrameworkCore;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamAPP
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=.; database=ExamDB; Trusted_connection=true;encrypt=false;");
        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Dept_Crs> dept_Crs { get; set; }
        public DbSet<Ins_Course> ins_Courses { get; set; }
        public DbSet<Ins_Department> ins_Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Crs> stud_Crs { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public DbSet<Choices> Choices { get; set; }
        public DbSet<Exam_Question_Crs> Exam_Question_Crs { get; set; }


        private void GeneraeteQuestions (int number , Choices Choice , Course course , List<Question> Queslist)
        {
            Queslist.AddRange( new Faker<Question>()
                .RuleFor(e => e.Q_Id, f => f.Random.Number(9100, 9189))
                .RuleFor(e => e.AnsID, f => Choice.Ch_Id)
                .RuleFor(e => e.AnsTitle, f => Choice.Ch_Title)
                .RuleFor(e => e.CrsID, f => course.Id)
                .RuleFor(e => e.type, f => "MCQ")
                .RuleFor(e => e.QuesTitle, f => f.Lorem.Paragraphs(1) .ToString() + " ?")
                .GenerateBetween(0, number));
        }

        private void GenerateChoices(int number, Question Ques , List<Choices> choicesList)
        {
            var choice_list = new Faker<Choices>()
            .RuleFor(e => e.Ch_Title, f => f.Commerce.ProductMaterial())
            .RuleFor(e => e.Ch_Id, f => f.Random.Number(150,200))
            .RuleFor(e => e.Q_ID, f => 360)
            .GenerateBetween(0, number);

            choicesList.AddRange(choice_list);
        }

        public DbSet<Student_Exams> Student_Exams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     

            modelBuilder.Entity<Course>().HasKey(x => x.Id);

            // var CourseLists = new Faker<Course>().RuleFor(e => e.Title, f => f.Person.FirstName).RuleFor(e => e.Id, f => f.Random.Number(10, 16)).GenerateBetween(1, 5);


             var CourseLists = new List<Course>() { new Course { Id=1 , Title="OOP"} };




             modelBuilder.Entity<Course>().HasData(CourseLists);
            #region Mahmoud's Region

            #region Exam Relation
            modelBuilder.Entity<Exam>().HasKey(e => e.Ex_Id);
                

                    modelBuilder.Entity<Exam>()
                                .HasOne(e => e.Course)
                                .WithMany(e => e.Crs_Exams)
                                .HasForeignKey(e => e.CrsID);

                    modelBuilder.Entity<Exam>().HasData(new Exam { CrsID = CourseLists[0].Id, Ex_Marks = 50, Ex_Name = "asd", Ex_Id = 1 , Course= null });
            #endregion

            #region questions & choices
            List<Choices> choiceLists = new List<Choices>();

            choiceLists.Add(new Choices { Ch_Id = 95, Q_ID = 60, Ch_Title = "front end framework" });

            List<Question> Queslist = new List<Question>();

            Queslist.Add(new Question { Q_Id=360 , AnsTitle="front end framework" , CrsID = CourseLists[0].Id , QuesTitle="why are we studying this ?" , Q_Mark=100,type="MCQ" });

          //  GeneraeteQuestions(10, choiceLists[0], CourseLists[0] , Queslist);
             //GenerateChoices(3 , Queslist[0] , choiceLists);

            modelBuilder.Entity<Choices>().HasKey(e => e.Ch_Id);
          /*  modelBuilder.Entity<Choices>().HasData( new Faker<Choices>().RuleFor(e => e.Ch_Title, f => f.Commerce.ProductName())
            .RuleFor(e => e.Ch_Id, f => f.Random.Number(1,15))
            .RuleFor(e => e.Q_ID, f => 9167)
            .GenerateBetween(0, 4)
        );*/
            modelBuilder.Entity<Choices>().HasOne(e => e.Question)
                        .WithMany(e => e.Choices)
                        .HasForeignKey(e => e.Q_ID);


                    modelBuilder.Entity<Question>().HasKey(e => e.Q_Id);
                  //  modelBuilder.Entity<Question>().HasData(Queslist);
                modelBuilder.Entity<Question>(config =>
                {
                    config.HasOne(q => q.Course)
                    .WithMany(c => c.Question)
                    .HasForeignKey(q => q.CrsID);

                    //config.HasOne(e => e.ModelChoice)
                    //.WithOne(e => e.Question)
                    //.HasForeignKey<Question>(q => q.AnsID);
                });


    

           // modelBuilder.Entity<Choices>().HasData(choiceLists);

            #endregion

            #region Many to many relations
            modelBuilder.Entity<Student_Exams>().HasKey(e => new { e.St_ID, e.Ex_ID });
                    modelBuilder.Entity<Student_Exams>()
                       .HasOne(e => e.Student)
                       .WithMany(e => e.Student_Exams)
                       .HasForeignKey(e => e.St_ID);
                

                    modelBuilder.Entity<Student_Exams>()
                       .HasOne(e => e.Exam)
                       .WithMany(e => e.Student_Exams)
                       .HasForeignKey(e => e.Ex_ID);

             //   modelBuilder.Entity<Exam_Question_Crs>().HasData(new Exam_Question_Crs { Crs_ID = CourseLists[0].Id, Ex_ID = 1, Ques_ID = Queslist[0].Q_Id , Course=null , Exam= null , Ex_Questions=null });
                modelBuilder.Entity<Exam_Question_Crs>().HasKey(e => new { e.Ex_ID, e.Ques_ID , e.Crs_ID });
           

                modelBuilder.Entity<Exam_Question_Crs>()
                    .HasOne(e => e.Ex_Questions)
                    .WithMany(e => e.Exam_Question_Crs)
                    .HasForeignKey(e => e.Ques_ID)
                    .OnDelete(DeleteBehavior.NoAction);
        


                    modelBuilder.Entity<Exam_Question_Crs>()
                       .HasOne(e => e.Exam)
                       .WithMany(e => e.Exam_Question_Crs)
                       .HasForeignKey(e => e.Ex_ID)
                        .OnDelete(DeleteBehavior.NoAction);


                modelBuilder.Entity<Exam_Question_Crs>()
                    .HasOne(e => e.Course)
                    .WithMany(e => e.Exam_Question_Crs)
                    .HasForeignKey(e => e.Crs_ID)
                     .OnDelete(DeleteBehavior.NoAction);









            modelBuilder.Entity<Stude_Answers>().HasKey(e => new { e.Ex_id, e.Q_id, e.Stud_id });


            modelBuilder.Entity<Stude_Answers>()
                .HasOne(e => e.Student)
                .WithMany(e => e.Stude_Answers)
                .HasForeignKey(e => e.Stud_id)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Stude_Answers>()
               .HasOne(e => e.Exam)
               .WithMany(e => e.Stude_Answers)
               .HasForeignKey(e => e.Ex_id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Stude_Answers>()
               .HasOne(e => e.Question)
               .WithMany(e => e.Stude_Answers)
               .HasForeignKey(e => e.Q_id)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Stude_Answers>()
                .HasOne(e => e.Answer)
                .WithMany(e => e.Stude_Answers)
                .HasForeignKey(e => e.ch_id)
                 .OnDelete(DeleteBehavior.NoAction);


            #endregion

            #endregion


            #region Mina & Mona

            modelBuilder.Entity<Student>(config =>
                {
                    config.HasOne(s => s.department)
                    .WithMany(q => q.students)
                    .HasForeignKey(s => s.DeptId);

                });

            modelBuilder.Entity<Ins_Course>(config =>
            {
                config.HasKey(e => new { e.Course_Id, e.Instructor_Id });
                config.HasOne(s => s.courses)
                .WithMany(q => q.Ins_Courses)
                .HasForeignKey(s => s.Course_Id)
                .OnDelete(DeleteBehavior.NoAction);

                config.HasOne(s => s.Instructors)
                .WithMany(ins => ins.Ins_Courses)
                .HasForeignKey(e => e.Instructor_Id)
                 .OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<Topic>(config =>
            {
                config.HasKey(e => new { e.ID, e.courseId });
                config.HasOne(e => e.courses)
                .WithMany(e => e.Topics)
                .HasForeignKey(e => e.courseId);
            });


            modelBuilder.Entity<Dept_Crs>(config =>
            {
                config.HasKey(e => new { e.Course_Id, e.Department_Id });
                config.HasOne(e => e.Course)
                .WithMany(e => e.Dept_Crs)
                .HasForeignKey(e => e.Course_Id);

                config.HasOne(e => e.Department)
                 .WithMany(e => e.dept_Crs)
                 .HasForeignKey(e => e.Department_Id);
            });

            modelBuilder.Entity<Stud_Crs>(config =>
            {
                config.HasKey(e => new { e.Course_Id, e.Student_Id });
                config.HasOne(e => e.Student)
                .WithMany(e => e.Stud_Crs)
                .HasForeignKey(e => e.Student_Id);

                config.HasOne(e => e.Course)
                 .WithMany(e => e.Stud_Crs)
                 .HasForeignKey(e => e.Course_Id);
            });

            modelBuilder.Entity<Ins_Department>(config =>
            {
                config.HasKey(e => new { e.Ins_ID, e.Dept_ID });
                config.HasOne(e => e.Instructor)
                .WithMany(e => e.Ins_Departments)
                .HasForeignKey(e => e.Ins_ID);

                config.HasOne(e => e.Departments)
                 .WithMany(e => e.Ins_Departments)
                 .HasForeignKey(e => e.Dept_ID);
            });
            #endregion


            //modelBuilder.Entity<Student>().HasData(new Student { ID = 1, FName = "Mahmoud", LName = "ALi", Age = 25, Address = "37 sixth street", DeptId = 1, DOB = DateTime.Now });
            modelBuilder.Entity<Instructor>().HasData(new List<Instructor> { new Instructor { Id=1,Name="ALyaa"  }
            , new Instructor { Id=2 , Name="Mona"  }
            });

            modelBuilder.Entity<Stud_Crs>().HasData(new List<Stud_Crs> { new Stud_Crs { Course_Id=1 , Student_Id=2 ,Grade=75 }
            , new Stud_Crs { Course_Id = 1, Student_Id = 1, Grade = 100 }
            
            });
            modelBuilder.Entity<Ins_Course>().HasData(new List<Ins_Course> { new Ins_Course { Course_Id=1 , Instructor_Id=1  }
            , new Ins_Course { Course_Id=2 , Instructor_Id=1  }
              , new Ins_Course { Course_Id=3 , Instructor_Id=1  }
            });
            modelBuilder.Entity<Course>().HasData( new List<Course> { new Course { Id = 2, Title = "nextJS" } , new Course { Id=3 , Title=".NET"} });
            modelBuilder.Entity<Topic>().HasData(new List<Topic> { new Topic { ID = 1 ,courseId=1 ,Title="Ineritance"}, new Topic { ID = 2, courseId = 1 , Title="Pointers" } });

            base.OnModelCreating(modelBuilder); 
        }
    }
}
