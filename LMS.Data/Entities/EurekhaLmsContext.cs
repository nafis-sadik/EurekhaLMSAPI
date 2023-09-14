using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMS.Entities;

public partial class EurekhaLmsContext : DbContext
{
    public EurekhaLmsContext()
    {
    }

    public EurekhaLmsContext(DbContextOptions<EurekhaLmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chapter> Chapters { get; set; }

    public virtual DbSet<ChapterContent> ChapterContents { get; set; }

    public virtual DbSet<ChapterContentType> ChapterContentTypes { get; set; }

    public virtual DbSet<Courese> Coureses { get; set; }

    public virtual DbSet<CourseEnrolement> CourseEnrolements { get; set; }

    public virtual DbSet<UserCourseProgressRecord> UserCourseProgressRecords { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserGroupMember> UserGroupMembers { get; set; }

    public virtual DbSet<UserGrouping> UserGroupings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EurekhaLMS;User ID=sa;TrustServerCertificate=True;Encrypt=False;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chapter>(entity =>
        {
            entity.Property(e => e.ChapterTitle)
                .IsRequired()
                .HasMaxLength(150);

            entity.HasOne(d => d.Course).WithMany(p => p.Chapters)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Chapters_Coureses");
        });

        modelBuilder.Entity<ChapterContent>(entity =>
        {
            entity.HasKey(e => e.ContentId);

            entity.HasOne(d => d.Chapter).WithMany(p => p.ChapterContents)
                .HasForeignKey(d => d.ChapterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChapterContents_Chapters");

            entity.HasOne(d => d.ContentType).WithMany(p => p.ChapterContents)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChapterContents_ChapterContentTypes");
        });

        modelBuilder.Entity<ChapterContentType>(entity =>
        {
            entity.HasKey(e => e.ContentTypeId);

            entity.Property(e => e.ContentTypeName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Courese>(entity =>
        {
            entity.HasKey(e => e.CourseId);

            entity.Property(e => e.CourseName)
                .IsRequired()
                .HasMaxLength(150);
        });

        modelBuilder.Entity<CourseEnrolement>(entity =>
        {
            entity.HasKey(e => e.EnrolementId);

            entity.ToTable("CourseEnrolement");

            entity.Property(e => e.EnrolementDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.CourseEnrolements)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseEnrolement_Coureses");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.CourseEnrolements)
                .HasForeignKey(d => d.UserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseEnrolement_UserGroup");
        });

        modelBuilder.Entity<UserCourseProgressRecord>(entity =>
        {
            entity.HasKey(e => e.ProgressRecordId);

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Chapter).WithMany(p => p.UserCourseProgressRecords)
                .HasForeignKey(d => d.ChapterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCourseProgressRecords_Chapters");

            entity.HasOne(d => d.Course).WithMany(p => p.UserCourseProgressRecords)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCourseProgressRecords_Coureses");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.ToTable("UserGroup");

            entity.Property(e => e.UserGroupTitle)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<UserGroupMember>(entity =>
        {
            entity.HasKey(e => e.GroupingRecordId);

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.UserGroup).WithMany(p => p.UserGroupMembers)
                .HasForeignKey(d => d.UserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupMembers_UserGroup");
        });

        modelBuilder.Entity<UserGrouping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserGrouping");

            entity.Property(e => e.Group)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
