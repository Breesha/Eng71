using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CodeFromSpartaAcademyModel
{
    public partial class SpartaAcademyContext : DbContext
    {
        public SpartaAcademyContext()
        {
        }

        public SpartaAcademyContext(DbContextOptions<SpartaAcademyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academy> Academies { get; set; }
        public virtual DbSet<CourseCatalog> CourseCatalogs { get; set; }
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }
        public virtual DbSet<CourseScheduleAttendee> CourseScheduleAttendees { get; set; }
        public virtual DbSet<CourseScheduleTrainer> CourseScheduleTrainers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SpartaAcademy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Academy>(entity =>
            {
                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.AcademyName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseCatalog>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__CourseCa__C92D7187C8B15202");

                entity.ToTable("CourseCatalog");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.ToTable("CourseSchedule");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<CourseScheduleAttendee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");
            });

            modelBuilder.Entity<CourseScheduleTrainer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CourseScheduleId).HasColumnName("CourseScheduleID");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.TrainerType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
