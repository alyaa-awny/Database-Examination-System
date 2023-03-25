﻿// <auto-generated />
using System;
using ExamAPP;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamAPP.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230319225716_v28")]
    partial class v28
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamAPP.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "OOP"
                        },
                        new
                        {
                            Id = 2,
                            Title = "nextJS"
                        },
                        new
                        {
                            Id = 3,
                            Title = ".NET"
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeptNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Dept_Crs", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Department_Id")
                        .HasColumnType("int");

                    b.HasKey("Course_Id", "Department_Id");

                    b.HasIndex("Department_Id");

                    b.ToTable("dept_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Instructor_Id")
                        .HasColumnType("int");

                    b.HasKey("Course_Id", "Instructor_Id");

                    b.HasIndex("Instructor_Id");

                    b.ToTable("ins_Courses");

                    b.HasData(
                        new
                        {
                            Course_Id = 1,
                            Instructor_Id = 1
                        },
                        new
                        {
                            Course_Id = 2,
                            Instructor_Id = 1
                        },
                        new
                        {
                            Course_Id = 3,
                            Instructor_Id = 1
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.HasKey("Ins_ID", "Dept_ID");

                    b.HasIndex("Dept_ID");

                    b.ToTable("ins_Departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ALyaa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mona"
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Choices", b =>
                {
                    b.Property<int>("Ch_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ch_Id"));

                    b.Property<string>("Ch_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Q_ID")
                        .HasColumnType("int");

                    b.HasKey("Ch_Id");

                    b.HasIndex("Q_ID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.Property<int>("Ex_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ex_Id"));

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("Ex_Marks")
                        .HasColumnType("int");

                    b.Property<string>("Ex_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ex_Id");

                    b.HasIndex("CrsID");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Ex_Id = 1,
                            CrsID = 1,
                            Ex_Marks = 50,
                            Ex_Name = "asd"
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam_Question_Crs", b =>
                {
                    b.Property<int>("Ex_ID")
                        .HasColumnType("int");

                    b.Property<int>("Ques_ID")
                        .HasColumnType("int");

                    b.Property<int>("Crs_ID")
                        .HasColumnType("int");

                    b.HasKey("Ex_ID", "Ques_ID", "Crs_ID");

                    b.HasIndex("Crs_ID");

                    b.HasIndex("Ques_ID");

                    b.ToTable("Exam_Question_Crs");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Question", b =>
                {
                    b.Property<int>("Q_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Q_Id"));

                    b.Property<int>("AnsID")
                        .HasColumnType("int");

                    b.Property<string>("AnsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CrsID")
                        .HasColumnType("int");

                    b.Property<int>("Q_Mark")
                        .HasColumnType("int");

                    b.Property<string>("QuesTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Q_Id");

                    b.HasIndex("CrsID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Stude_Answers", b =>
                {
                    b.Property<int>("Ex_id")
                        .HasColumnType("int");

                    b.Property<int>("Q_id")
                        .HasColumnType("int");

                    b.Property<int>("Stud_id")
                        .HasColumnType("int");

                    b.Property<int>("ch_id")
                        .HasColumnType("int");

                    b.HasKey("Ex_id", "Q_id", "Stud_id");

                    b.HasIndex("Q_id");

                    b.HasIndex("Stud_id");

                    b.HasIndex("ch_id");

                    b.ToTable("Stude_Answers");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Student_Exams", b =>
                {
                    b.Property<int>("St_ID")
                        .HasColumnType("int");

                    b.Property<int>("Ex_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("St_ID", "Ex_ID");

                    b.HasIndex("Ex_ID");

                    b.ToTable("Student_Exams");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Student_Id")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Course_Id", "Student_Id");

                    b.HasIndex("Student_Id");

                    b.ToTable("stud_Crs");

                    b.HasData(
                        new
                        {
                            Course_Id = 1,
                            Student_Id = 2,
                            Grade = 75
                        },
                        new
                        {
                            Course_Id = 1,
                            Student_Id = 1,
                            Grade = 100
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DeptId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ExamAPP.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID", "courseId");

                    b.HasIndex("courseId");

                    b.ToTable("topics");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            courseId = 1,
                            Title = "Ineritance"
                        },
                        new
                        {
                            ID = 2,
                            courseId = 1,
                            Title = "Pointers"
                        });
                });

            modelBuilder.Entity("ExamAPP.Models.Dept_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Dept_Crs")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Department", "Department")
                        .WithMany("dept_Crs")
                        .HasForeignKey("Department_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Course", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "courses")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Instructor", "Instructors")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("Instructor_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Instructors");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Ins_Department", b =>
                {
                    b.HasOne("ExamAPP.Models.Department", "Departments")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Instructor", "Instructor")
                        .WithMany("Ins_Departments")
                        .HasForeignKey("Ins_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Choices", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("Q_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Crs_Exams")
                        .HasForeignKey("CrsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam_Question_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Exam_Question_Crs")
                        .HasForeignKey("Crs_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Mahmoud.Exam", "Exam")
                        .WithMany("Exam_Question_Crs")
                        .HasForeignKey("Ex_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Mahmoud.Question", "Ex_Questions")
                        .WithMany("Exam_Question_Crs")
                        .HasForeignKey("Ques_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Ex_Questions");

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Question", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Question")
                        .HasForeignKey("CrsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Stude_Answers", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Exam", "Exam")
                        .WithMany("Stude_Answers")
                        .HasForeignKey("Ex_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Mahmoud.Question", "Question")
                        .WithMany("Stude_Answers")
                        .HasForeignKey("Q_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Stude_Answers")
                        .HasForeignKey("Stud_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Mahmoud.Choices", "Answer")
                        .WithMany("Stude_Answers")
                        .HasForeignKey("ch_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Exam");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Student_Exams", b =>
                {
                    b.HasOne("ExamAPP.Models.Mahmoud.Exam", "Exam")
                        .WithMany("Student_Exams")
                        .HasForeignKey("Ex_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Student_Exams")
                        .HasForeignKey("St_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamAPP.Models.Stud_Crs", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "Course")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamAPP.Models.Student", "Student")
                        .WithMany("Stud_Crs")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.HasOne("ExamAPP.Models.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("ExamAPP.Models.Topic", b =>
                {
                    b.HasOne("ExamAPP.Models.Course", "courses")
                        .WithMany("Topics")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("courses");
                });

            modelBuilder.Entity("ExamAPP.Models.Course", b =>
                {
                    b.Navigation("Crs_Exams");

                    b.Navigation("Dept_Crs");

                    b.Navigation("Exam_Question_Crs");

                    b.Navigation("Ins_Courses");

                    b.Navigation("Question");

                    b.Navigation("Stud_Crs");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("ExamAPP.Models.Department", b =>
                {
                    b.Navigation("Ins_Departments");

                    b.Navigation("dept_Crs");

                    b.Navigation("students");
                });

            modelBuilder.Entity("ExamAPP.Models.Instructor", b =>
                {
                    b.Navigation("Ins_Courses");

                    b.Navigation("Ins_Departments");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Choices", b =>
                {
                    b.Navigation("Stude_Answers");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Exam", b =>
                {
                    b.Navigation("Exam_Question_Crs");

                    b.Navigation("Stude_Answers");

                    b.Navigation("Student_Exams");
                });

            modelBuilder.Entity("ExamAPP.Models.Mahmoud.Question", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("Exam_Question_Crs");

                    b.Navigation("Stude_Answers");
                });

            modelBuilder.Entity("ExamAPP.Models.Student", b =>
                {
                    b.Navigation("Stud_Crs");

                    b.Navigation("Stude_Answers");

                    b.Navigation("Student_Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
