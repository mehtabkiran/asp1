using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace databaseconnection.Models
{
    public partial class finalprojectContext : DbContext
    {
        public finalprojectContext(DbContextOptions<finalprojectContext> abc): base(abc)
        { }
        public virtual DbSet<Advisor> Advisor { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Finance> Finance { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<ResourceOfEvent> ResourceOfEvent { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SocietyEvent> SocietyEvent { get; set; }
        public virtual DbSet<Sponser> Sponser { get; set; }
        public virtual DbSet<SponserService> SponserService { get; set; }
        public virtual DbSet<Subevent> Subevent { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Tenure> Tenure { get; set; }

        // Unable to generate entity type for table 'dbo.ADVISOR_TEAM_ASSOCIATION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEAM_TENURE_DESINATION_LINK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEAM_POSSESS_SKILL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEAM_ORGANIZE_EVENT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SPONSER_ASSOCIATION_EVENT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SPONSER_ASSOCIATION_SERVICE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESOURCES_ASSOCIATION_EVENT'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-B3IASG2;Database=finalproject;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advisor>(entity =>
            {
                entity.HasKey(e => e.AId)
                    .HasName("A_id_pk");

                entity.ToTable("ADVISOR");

                entity.Property(e => e.AId)
                    .HasColumnName("A_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.ADepName)
                    .IsRequired()
                    .HasColumnName("A_dep_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AEmail)
                    .IsRequired()
                    .HasColumnName("A_email")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.AGender)
                    .IsRequired()
                    .HasColumnName("A_gender")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.AName)
                    .IsRequired()
                    .HasColumnName("A_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.APhone)
                    .IsRequired()
                    .HasColumnName("A_phone")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.AScale)
                    .IsRequired()
                    .HasColumnName("A_scale")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.DesId)
                    .HasName("Des_id_pk");

                entity.ToTable("DESIGNATION");

                entity.Property(e => e.DesId)
                    .HasColumnName("Des_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.DesName)
                    .IsRequired()
                    .HasColumnName("Des_name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Finance>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("trans_id_pk");

                entity.ToTable("finance");

                entity.Property(e => e.TransId)
                    .HasColumnName("trans_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AId)
                    .IsRequired()
                    .HasColumnName("A_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.Budget)
                    .HasColumnName("budget")
                    .HasColumnType("numeric");

                entity.Property(e => e.EvExpenditure)
                    .HasColumnName("Ev_expenditure")
                    .HasColumnType("money");

                entity.Property(e => e.EvName)
                    .IsRequired()
                    .HasColumnName("Ev_name")
                    .HasColumnType("char(25)");

                entity.Property(e => e.IncomeFromEvent)
                    .HasColumnName("income_from_event")
                    .HasColumnType("numeric");

                entity.Property(e => e.SessionName)
                    .IsRequired()
                    .HasColumnName("Session_name")
                    .HasColumnType("char(9)");

                entity.Property(e => e.SocietyAmount)
                    .HasColumnName("society_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.TAmount)
                    .HasColumnName("t_amount")
                    .HasColumnType("money");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.Finance)
                    .HasForeignKey(d => d.AId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("A_id_fkk");

                entity.HasOne(d => d.EvNameNavigation)
                    .WithMany(p => p.Finance)
                    .HasForeignKey(d => d.EvName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("ev_name_fk5");

                entity.HasOne(d => d.SessionNameNavigation)
                    .WithMany(p => p.Finance)
                    .HasForeignKey(d => d.SessionName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Session_name_fkkk");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("P_id");

                entity.ToTable("PARTICIPANT");

                entity.Property(e => e.PId)
                    .HasColumnName("P_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.PGender)
                    .HasColumnName("P_gender")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasColumnName("P_name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.PNocId)
                    .HasColumnName("P_NOC_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.PPhone)
                    .HasColumnName("P_phone")
                    .HasColumnType("char(12)");

                entity.Property(e => e.PUniName)
                    .IsRequired()
                    .HasColumnName("P_uni_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.RollNumber)
                    .IsRequired()
                    .HasColumnName("Roll_number")
                    .HasColumnType("char(12)");

                entity.Property(e => e.SeId)
                    .HasColumnName("se_id")
                    .HasColumnType("char(4)");

                entity.HasOne(d => d.RollNumberNavigation)
                    .WithMany(p => p.Participant)
                    .HasForeignKey(d => d.RollNumber)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Roll_number_fk5");

                entity.HasOne(d => d.Se)
                    .WithMany(p => p.Participant)
                    .HasForeignKey(d => d.SeId)
                    .HasConstraintName("se_id_fk1");
            });

            modelBuilder.Entity<ResourceOfEvent>(entity =>
            {
                entity.HasKey(e => e.ResId)
                    .HasName("res_id_pk");

                entity.ToTable("RESOURCE_OF_EVENT");

                entity.Property(e => e.ResId)
                    .HasColumnName("Res_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.ResName)
                    .IsRequired()
                    .HasColumnName("Res_name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.SkId)
                    .HasName("Sk_id_pk");

                entity.ToTable("SKILL");

                entity.Property(e => e.SkId)
                    .HasColumnName("Sk_id")
                    .HasColumnType("char(5)");

                entity.Property(e => e.SkName)
                    .IsRequired()
                    .HasColumnName("Sk_name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SocietyEvent>(entity =>
            {
                entity.HasKey(e => e.EvName)
                    .HasName("Ev_name_pk");

                entity.ToTable("SOCIETY_EVENT");

                entity.Property(e => e.EvName)
                    .HasColumnName("Ev_name")
                    .HasColumnType("char(25)");

                entity.Property(e => e.AId)
                    .HasColumnName("A_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.EvDateOfApproval)
                    .HasColumnName("Ev_date_of_approval")
                    .HasColumnType("date");

                entity.Property(e => e.EvEndDate)
                    .HasColumnName("Ev_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EvStartDate)
                    .HasColumnName("Ev_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.EvType)
                    .IsRequired()
                    .HasColumnName("Ev_type")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SessionName)
                    .IsRequired()
                    .HasColumnName("Session_name")
                    .HasColumnType("char(9)");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.SocietyEvent)
                    .HasForeignKey(d => d.AId)
                    .HasConstraintName("A_id_fk3");

                entity.HasOne(d => d.SessionNameNavigation)
                    .WithMany(p => p.SocietyEvent)
                    .HasForeignKey(d => d.SessionName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Session_name_fk1");
            });

            modelBuilder.Entity<Sponser>(entity =>
            {
                entity.HasKey(e => e.SpId)
                    .HasName("Sp_id_pk");

                entity.ToTable("SPONSER");

                entity.Property(e => e.SpId)
                    .HasColumnName("Sp_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.SpName)
                    .IsRequired()
                    .HasColumnName("Sp_name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SponserService>(entity =>
            {
                entity.HasKey(e => e.SerId)
                    .HasName("Ser_id_pk");

                entity.ToTable("SPONSER_SERVICE");

                entity.Property(e => e.SerId)
                    .HasColumnName("Ser_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.SerName)
                    .IsRequired()
                    .HasColumnName("Ser_name")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Subevent>(entity =>
            {
                entity.HasKey(e => e.SeId)
                    .HasName("se_id_pk");

                entity.ToTable("SUBEVENT");

                entity.Property(e => e.SeId)
                    .HasColumnName("se_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.EvName)
                    .IsRequired()
                    .HasColumnName("Ev_name")
                    .HasColumnType("char(25)");

                entity.Property(e => e.SeName)
                    .IsRequired()
                    .HasColumnName("se_name")
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.EvNameNavigation)
                    .WithMany(p => p.Subevent)
                    .HasForeignKey(d => d.EvName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Ev_name_fk3");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.RollNumber)
                    .HasName("Roll_number_pk");

                entity.ToTable("TEAM");

                entity.Property(e => e.RollNumber)
                    .HasColumnName("Roll_number")
                    .HasColumnType("char(12)");

                entity.Property(e => e.TAddress)
                    .HasColumnName("T_address")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TCgpa)
                    .HasColumnName("T_CGPA")
                    .HasColumnType("char(4)");

                entity.Property(e => e.TDepName)
                    .IsRequired()
                    .HasColumnName("T_dep_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TEmail)
                    .IsRequired()
                    .HasColumnName("T_email")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TGender)
                    .IsRequired()
                    .HasColumnName("T_gender")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.TName)
                    .IsRequired()
                    .HasColumnName("T_name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TPhoneNumber)
                    .IsRequired()
                    .HasColumnName("T_phone_number")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.TSemester)
                    .HasColumnName("T_semester")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<Tenure>(entity =>
            {
                entity.HasKey(e => e.SessionName)
                    .HasName("session_name_pk");

                entity.ToTable("TENURE");

                entity.Property(e => e.SessionName)
                    .HasColumnName("Session_name")
                    .HasColumnType("char(9)");

                entity.Property(e => e.AId)
                    .IsRequired()
                    .HasColumnName("A_id")
                    .HasColumnType("char(4)");

                entity.Property(e => e.Budget).HasColumnType("money");

                entity.Property(e => e.TEndDate)
                    .HasColumnName("T_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.TStartDate)
                    .HasColumnName("T_start_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.Tenure)
                    .HasForeignKey(d => d.AId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("A_id_fk");
            });
        }
    }
}