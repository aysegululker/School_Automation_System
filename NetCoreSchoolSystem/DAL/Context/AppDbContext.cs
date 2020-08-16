using DAL.Entity;
using DAL.Entity.Base;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        public DbSet<RoomLessonTeacher> RoomLessonTeachers { get; set; }



        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();
            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            
            string user = "admin"; //sadece admin statüsündekilerin değiştirme yetkisi bulunmaktadır.
            string ip = CoreEntity.GetHostName();
            foreach (var item in modifiedEntries)
            {
                CoreEntity coreEntity = item.Entity as CoreEntity;
                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        coreEntity.CreatedAdUserName = identity;
                        coreEntity.CreatedComputerName = computerName;
                        coreEntity.CreatedDate = dateTime;
                        coreEntity.CreatedIP = ip;
                        coreEntity.CreatedBy = user;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        coreEntity.ModifiedAdUserName = identity;
                        coreEntity.ModifiedComputerName = computerName;
                        coreEntity.ModifiedDate = dateTime;
                        coreEntity.ModifiedIP = ip;
                        coreEntity.ModifiedBy = user;
                    }
                }
            }
            return base.SaveChanges();
        }



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<StudentLesson>().HasKey(x => new { x.StudentID, x.LessonID });
        //    builder.Entity<StudentSuccessDocument>().HasKey(x => new { x.StudentID, x.SuccessDocumentID });
        //    builder.Entity<StudentSyllabusTable>().HasKey(x => new { x.StudentID, x.SyllabusTableID });
        //    builder.Entity<StudentTeacher>().HasKey(x => new { x.StudentID, x.TeacherID });
        //    builder.Entity<TeacherClassRoom>().HasKey(x => new { x.TeacherID, x.ClassRoomID });
        //    builder.Entity<TeacherLesson>().HasKey(x => new { x.TeacherID, x.LessonID });
        //    builder.Entity<TeacherNoteEntry>().HasKey(x => new { x.TeacherID, x.NoteEntryID });
        //    builder.Entity<TeacherSyllabusTable>().HasKey(x => new { x.TeacherID, x.SyllabusTableID });
        //    builder.Entity<RoomLesson>().HasKey(x => new { x.ClassRoomID, x.LessonID });

        //    base.OnModelCreating(builder);
        //}
    }
}
