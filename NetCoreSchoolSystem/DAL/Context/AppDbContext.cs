using DAL.Entity;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        //Tables
        public DbSet<Absenteeism> Absenteeisms { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonHour> LessonHours { get; set; }
        public DbSet<NoteEntry> NoteEntries { get; set; }
        public DbSet<PeriodInformation> PeriodInformations { get; set; }
        public DbSet<PreRegistration> PreRegistrations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SuccessDocument> SuccessDocuments { get; set; }
        public DbSet<SuccessDocumentIdentification> SuccessDocumentIdentifications { get; set; }
        public DbSet<SyllabusTable> SyllabusTables { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        
        //OneToMany Tables
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ClassDefination> ClassDefinations { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        //ManyToMany
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<StudentSuccessDocument> StudentSuccessDocuments { get; set; }
        public DbSet<StudentSyllabusTable> StudentSyllabusTables { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<TeacherClassRoom> TeacherClassRooms { get; set; }
        public DbSet<TeacherLesson> TeacherLessons { get; set; }
        public DbSet<TeacherNoteEntry> TeacherNoteEntries { get; set; }
        public DbSet<TeacherSyllabusTable> TeacherSyllabusTables { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentLesson>().HasKey(x => new { x.StudentID, x.LessonID });
            builder.Entity<StudentSuccessDocument>().HasKey(x => new { x.StudentID, x.SuccessDocumentID });
            builder.Entity<StudentSyllabusTable>().HasKey(x => new { x.StudentID, x.SyllabusTableID });
            builder.Entity<StudentTeacher>().HasKey(x => new { x.StudentID, x.TeacherID });
            builder.Entity<TeacherClassRoom>().HasKey(x => new { x.TeacherID, x.ClassRoomID });
            builder.Entity<TeacherLesson>().HasKey(x => new { x.TeacherID, x.LessonID });
            builder.Entity<TeacherNoteEntry>().HasKey(x => new { x.TeacherID, x.NoteEntryID });
            builder.Entity<TeacherSyllabusTable>().HasKey(x => new { x.TeacherID, x.SyllabusTableID });

            base.OnModelCreating(builder);
        }
    }
}
