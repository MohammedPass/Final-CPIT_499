﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeniorProject.Data;

#nullable disable

namespace SeniorProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221023162504_six")]
    partial class six
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SeniorProject.Models.Activities", b =>
                {
                    b.Property<int>("Activities_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Activities_Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activity_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Activities_Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Assessing_SO")
                        .HasColumnType("bit");

                    b.Property<string>("CLO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LOD_RefLOD_Id")
                        .HasColumnType("int");

                    b.Property<int>("SO")
                        .HasColumnType("int");

                    b.Property<int>("course_Refcourse_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LOD_RefLOD_Id");

                    b.HasIndex("course_Refcourse_Id");

                    b.ToTable("ArticulationMatrix");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrixActivities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticulationMatrix_RefId")
                        .HasColumnType("int");

                    b.Property<int>("activity_RefActivities_Id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ArticulationMatrix_RefId");

                    b.HasIndex("activity_RefActivities_Id");

                    b.ToTable("ArticulationMatrixActivities");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrixAssessmentTools", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticulationMatrix_RefId")
                        .HasColumnType("int");

                    b.Property<int>("AssessmentTools_ReftoolId")
                        .HasColumnType("int");

                    b.Property<int>("WeekNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticulationMatrix_RefId");

                    b.HasIndex("AssessmentTools_ReftoolId");

                    b.ToTable("ArticulationMatrixAssessmentTools");
                });

            modelBuilder.Entity("SeniorProject.Models.AssessmentTools", b =>
                {
                    b.Property<int>("toolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("toolId"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("toolId");

                    b.ToTable("AssessmentTools");
                });

            modelBuilder.Entity("SeniorProject.Models.Course", b =>
                {
                    b.Property<int>("course_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_Id"), 1L, 1);

                    b.Property<string>("course_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("course_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SeniorProject.Models.CourseCatalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("WeekNo")
                        .HasColumnType("int");

                    b.Property<string>("catalog_topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_Refcourse_Id")
                        .HasColumnType("int");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("course_Refcourse_Id");

                    b.ToTable("CourseCatalog");
                });

            modelBuilder.Entity("SeniorProject.Models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dept_Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SeniorProject.Models.FacultyMembers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AcademicID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FacultyMembers");
                });

            modelBuilder.Entity("SeniorProject.Models.GradeDistribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticulationMatrix_RefId")
                        .HasColumnType("int");

                    b.Property<int>("SO1")
                        .HasColumnType("int");

                    b.Property<int>("SO2")
                        .HasColumnType("int");

                    b.Property<int>("SO3")
                        .HasColumnType("int");

                    b.Property<int>("SO4")
                        .HasColumnType("int");

                    b.Property<int>("SO5")
                        .HasColumnType("int");

                    b.Property<int>("SO6")
                        .HasColumnType("int");

                    b.Property<bool>("assessing_SO")
                        .HasColumnType("bit");

                    b.Property<double>("percentage")
                        .HasColumnType("float");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("week_Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticulationMatrix_RefId");

                    b.ToTable("GradeDistribution");
                });

            modelBuilder.Entity("SeniorProject.Models.LOD", b =>
                {
                    b.Property<int>("LOD_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LOD_Id"), 1L, 1);

                    b.Property<string>("LOD_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOD_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LOD_Id");

                    b.ToTable("LOD");
                });

            modelBuilder.Entity("SeniorProject.Models.Session", b =>
                {
                    b.Property<int>("session_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("session_Id"), 1L, 1);

                    b.Property<int>("Dept_RefDept_Id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("session_Id");

                    b.HasIndex("Dept_RefDept_Id");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("SeniorProject.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourse", b =>
                {
                    b.Property<int>("StuCourse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StuCourse_Id"), 1L, 1);

                    b.Property<int>("Student_RefStudentId")
                        .HasColumnType("int");

                    b.Property<int>("course_Refcourse_Id")
                        .HasColumnType("int");

                    b.Property<double>("marks")
                        .HasColumnType("float");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("session_Refsession_Id")
                        .HasColumnType("int");

                    b.HasKey("StuCourse_Id");

                    b.HasIndex("Student_RefStudentId");

                    b.HasIndex("course_Refcourse_Id");

                    b.HasIndex("session_Refsession_Id");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourseActivities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Activities_RefActivities_Id")
                        .HasColumnType("int");

                    b.Property<int>("StuCourse_RefStuCourse_Id")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Activities_RefActivities_Id");

                    b.HasIndex("StuCourse_RefStuCourse_Id");

                    b.ToTable("StudentCourseActivities");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourseAssessmentTools", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("StuCourse_RefStuCourse_Id")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("marks")
                        .HasColumnType("float");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tool_ReftoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StuCourse_RefStuCourse_Id");

                    b.HasIndex("tool_ReftoolId");

                    b.ToTable("StudentCourseAssessmentTools");
                });

            modelBuilder.Entity("SeniorProject.Models.Teachers", b =>
                {
                    b.Property<int>("teacher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacher_Id"), 1L, 1);

                    b.Property<int>("AcademicId")
                        .HasColumnType("int");

                    b.Property<string>("teacher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacher_Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SeniorProject.Models.TeachersCourse", b =>
                {
                    b.Property<int>("teacherCourse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherCourse_Id"), 1L, 1);

                    b.Property<string>("SemesterEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SemesterStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_Refcourse_Id")
                        .HasColumnType("int");

                    b.Property<int>("teacher_Refteacher_Id")
                        .HasColumnType("int");

                    b.HasKey("teacherCourse_Id");

                    b.HasIndex("course_Refcourse_Id");

                    b.HasIndex("teacher_Refteacher_Id");

                    b.ToTable("TeachersCourse");
                });

            modelBuilder.Entity("SeniorProject.Models.TeachingSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("teacherCourse_RefteacherCourse_Id")
                        .HasColumnType("int");

                    b.Property<int>("week_Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("teacherCourse_RefteacherCourse_Id");

                    b.ToTable("TeachingSchedule");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrix", b =>
                {
                    b.HasOne("SeniorProject.Models.LOD", "LOD_Ref")
                        .WithMany()
                        .HasForeignKey("LOD_RefLOD_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.Course", "course_Ref")
                        .WithMany()
                        .HasForeignKey("course_Refcourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LOD_Ref");

                    b.Navigation("course_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrixActivities", b =>
                {
                    b.HasOne("SeniorProject.Models.ArticulationMatrix", "ArticulationMatrix_Ref")
                        .WithMany()
                        .HasForeignKey("ArticulationMatrix_RefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.Activities", "activity_Ref")
                        .WithMany()
                        .HasForeignKey("activity_RefActivities_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticulationMatrix_Ref");

                    b.Navigation("activity_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.ArticulationMatrixAssessmentTools", b =>
                {
                    b.HasOne("SeniorProject.Models.ArticulationMatrix", "ArticulationMatrix_Ref")
                        .WithMany()
                        .HasForeignKey("ArticulationMatrix_RefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.AssessmentTools", "AssessmentTools_Ref")
                        .WithMany()
                        .HasForeignKey("AssessmentTools_ReftoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticulationMatrix_Ref");

                    b.Navigation("AssessmentTools_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.CourseCatalog", b =>
                {
                    b.HasOne("SeniorProject.Models.Course", "course_Ref")
                        .WithMany()
                        .HasForeignKey("course_Refcourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.GradeDistribution", b =>
                {
                    b.HasOne("SeniorProject.Models.ArticulationMatrix", "ArticulationMatrix_Ref")
                        .WithMany()
                        .HasForeignKey("ArticulationMatrix_RefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticulationMatrix_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.Session", b =>
                {
                    b.HasOne("SeniorProject.Models.Department", "Dept_Ref")
                        .WithMany()
                        .HasForeignKey("Dept_RefDept_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourse", b =>
                {
                    b.HasOne("SeniorProject.Models.Student", "Student_Ref")
                        .WithMany()
                        .HasForeignKey("Student_RefStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.Course", "course_Ref")
                        .WithMany()
                        .HasForeignKey("course_Refcourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.Session", "session_Ref")
                        .WithMany()
                        .HasForeignKey("session_Refsession_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student_Ref");

                    b.Navigation("course_Ref");

                    b.Navigation("session_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourseActivities", b =>
                {
                    b.HasOne("SeniorProject.Models.Activities", "Activities_Ref")
                        .WithMany()
                        .HasForeignKey("Activities_RefActivities_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.StudentCourse", "StuCourse_Ref")
                        .WithMany()
                        .HasForeignKey("StuCourse_RefStuCourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activities_Ref");

                    b.Navigation("StuCourse_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.StudentCourseAssessmentTools", b =>
                {
                    b.HasOne("SeniorProject.Models.StudentCourse", "StuCourse_Ref")
                        .WithMany()
                        .HasForeignKey("StuCourse_RefStuCourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.AssessmentTools", "tool_Ref")
                        .WithMany()
                        .HasForeignKey("tool_ReftoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StuCourse_Ref");

                    b.Navigation("tool_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.TeachersCourse", b =>
                {
                    b.HasOne("SeniorProject.Models.Course", "course_Ref")
                        .WithMany()
                        .HasForeignKey("course_Refcourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeniorProject.Models.Teachers", "teacher_Ref")
                        .WithMany()
                        .HasForeignKey("teacher_Refteacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course_Ref");

                    b.Navigation("teacher_Ref");
                });

            modelBuilder.Entity("SeniorProject.Models.TeachingSchedule", b =>
                {
                    b.HasOne("SeniorProject.Models.TeachersCourse", "teacherCourse_Ref")
                        .WithMany()
                        .HasForeignKey("teacherCourse_RefteacherCourse_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacherCourse_Ref");
                });
#pragma warning restore 612, 618
        }
    }
}
