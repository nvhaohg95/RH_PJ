using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using RH_PJ.Common.Base;

namespace RH_PJ.Models
{
    public partial class RH_PJContext : DbContext
    {
        public RH_PJContext()
        {
        }

        public RH_PJContext(DbContextOptions<RH_PJContext> options, IConfiguration configuration)
            : base(options)
        {
        }

        public virtual DbSet<tbl_AR> tbl_ARs { get; set; } = null!;
        public virtual DbSet<tbl_Account> tbl_Accounts { get; set; } = null!;
        public virtual DbSet<tbl_AccountInfo> tbl_AccountInfos { get; set; } = null!;
        public virtual DbSet<tbl_Bill> tbl_Bills { get; set; } = null!;
        public virtual DbSet<tbl_BillDetail> tbl_BillDetails { get; set; } = null!;
        public virtual DbSet<tbl_Building> tbl_Buildings { get; set; } = null!;
        public virtual DbSet<tbl_Capacitor> tbl_Capacitors { get; set; } = null!;
        public virtual DbSet<tbl_Contract> tbl_Contracts { get; set; } = null!;
        public virtual DbSet<tbl_CustomerContract> tbl_CustomerContracts { get; set; } = null!;
        public virtual DbSet<tbl_Fee> tbl_Fees { get; set; } = null!;
        public virtual DbSet<tbl_FeesBR> tbl_FeesBRs { get; set; } = null!;
        public virtual DbSet<tbl_File> tbl_Files { get; set; } = null!;
        public virtual DbSet<tbl_MainCapacitor> tbl_MainCapacitors { get; set; } = null!;
        public virtual DbSet<tbl_PaymentHistory> tbl_PaymentHistories { get; set; } = null!;
        public virtual DbSet<tbl_RC> tbl_RCs { get; set; } = null!;
        public virtual DbSet<tbl_Room> tbl_Rooms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationHelper.config.GetConnectionString("DbContext");
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_AR>(entity =>
            {
                entity.HasKey(e => e.AR_Guid);

                entity.ToTable("tbl_AR");

                entity.Property(e => e.AR_Guid).HasMaxLength(100);

                entity.Property(e => e.Account_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerContract_Guid).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Room_Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<tbl_Account>(entity =>
            {
                entity.HasKey(e => e.Account_Guid);

                entity.ToTable("tbl_Account");

                entity.Property(e => e.Account_Guid).HasMaxLength(100);

                entity.Property(e => e.Account_Code).HasMaxLength(100);

                entity.Property(e => e.Account_Email).HasMaxLength(250);

                entity.Property(e => e.Account_Password).HasMaxLength(250);

                entity.Property(e => e.Account_Phone).HasMaxLength(50);

                entity.Property(e => e.Account_Role).HasComment("0. Admin\r\n1. Client\r\n2. Customer");

                entity.Property(e => e.Account_Status).HasComment("1. NotActived\r\n2. Actived\r\n3. Blocked\r\n");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_AccountInfo>(entity =>
            {
                entity.HasKey(e => e.AccountInfo_Guid);

                entity.ToTable("tbl_AccountInfo");

                entity.Property(e => e.AccountInfo_Guid).HasMaxLength(50);

                entity.Property(e => e.AccountInfo_Address).HasMaxLength(250);

                entity.Property(e => e.AccountInfo_Birthday).HasColumnType("datetime");

                entity.Property(e => e.AccountInfo_District).HasMaxLength(250);

                entity.Property(e => e.AccountInfo_FirstName).HasMaxLength(250);

                entity.Property(e => e.AccountInfo_Gender).HasMaxLength(50);

                entity.Property(e => e.AccountInfo_LastName).HasMaxLength(250);

                entity.Property(e => e.AccountInfo_Ward).HasMaxLength(250);

                entity.Property(e => e.AccountIno_Nationality).HasMaxLength(250);

                entity.Property(e => e.Account_Guid).HasMaxLength(100);

                entity.Property(e => e.AccoutnInfo_City).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account_Gu)
                    .WithMany(p => p.tbl_AccountInfos)
                    .HasForeignKey(d => d.Account_Guid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_AccountInfo_tbl_Account");
            });

            modelBuilder.Entity<tbl_Bill>(entity =>
            {
                entity.HasKey(e => e.Bill_Guid);

                entity.ToTable("tbl_Bill");

                entity.Property(e => e.Bill_Guid).HasMaxLength(100);

                entity.Property(e => e.Building_Guid).HasMaxLength(100);

                entity.Property(e => e.ClientAccount_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccount_Guid).HasMaxLength(100);

                entity.Property(e => e.CustomerContract_Guid).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Payment_Method).HasComment("1. Cash\r\n2. Bank\r\n3. Momo");

                entity.Property(e => e.Payment_Status).HasComment("1. Not Pay\r\n2. Paid\r\n3. In Debt");

                entity.Property(e => e.Room_Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<tbl_BillDetail>(entity =>
            {
                entity.HasKey(e => e.BillDetail_Guid);

                entity.ToTable("tbl_BillDetail");

                entity.Property(e => e.BillDetail_Guid).HasMaxLength(100);

                entity.Property(e => e.BillDetail_FeeName).HasMaxLength(500);

                entity.Property(e => e.BillDetail_FeeUnit).HasMaxLength(50);

                entity.Property(e => e.Bill_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_Building>(entity =>
            {
                entity.HasKey(e => e.Building_Guid);

                entity.ToTable("tbl_Building");

                entity.Property(e => e.Building_Guid).HasMaxLength(100);

                entity.Property(e => e.Account_Code).HasMaxLength(100);

                entity.Property(e => e.Account_Guid).HasMaxLength(100);

                entity.Property(e => e.Building_Address).HasMaxLength(200);

                entity.Property(e => e.Building_City).HasMaxLength(200);

                entity.Property(e => e.Building_Code).HasMaxLength(100);

                entity.Property(e => e.Building_Country).HasMaxLength(200);

                entity.Property(e => e.Building_District).HasMaxLength(200);

                entity.Property(e => e.Building_Name).HasMaxLength(200);

                entity.Property(e => e.Building_Status).HasComment("0. Renting\r\n1. Selling\r\n");

                entity.Property(e => e.Building_Summary).HasMaxLength(500);

                entity.Property(e => e.Building_Type).HasComment("0. Motel\r\n1. Building\r\n2. Hotel\r\n");

                entity.Property(e => e.Building_Ward).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_Capacitor>(entity =>
            {
                entity.HasKey(e => e.Capacitor_Guid);

                entity.ToTable("tbl_Capacitor");

                entity.Property(e => e.Capacitor_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainCapacitor_Guid).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_Contract>(entity =>
            {
                entity.HasKey(e => e.Contract_Guid);

                entity.ToTable("tbl_Contract");

                entity.Property(e => e.Contract_Guid).HasMaxLength(100);

                entity.Property(e => e.Account_Guid).HasMaxLength(100);

                entity.Property(e => e.Contract_Code).HasMaxLength(100);

                entity.Property(e => e.Contract_ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Contract_SignedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_CustomerContract>(entity =>
            {
                entity.HasKey(e => e.CustomerContract_Guid);

                entity.ToTable("tbl_CustomerContract");

                entity.Property(e => e.CustomerContract_Guid).HasMaxLength(100);

                entity.Property(e => e.Building_Guid).HasMaxLength(100);

                entity.Property(e => e.ClientAccount_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccount_Guid).HasMaxLength(100);

                entity.Property(e => e.CustomerContract_ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerContract_SignedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerContract_Status).HasComment("1. Still due\r\n2. Expired");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Room_Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<tbl_Fee>(entity =>
            {
                entity.HasKey(e => e.Fees_Guid);

                entity.Property(e => e.Fees_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fees_Code).HasMaxLength(100);

                entity.Property(e => e.Fees_Title).HasMaxLength(200);

                entity.Property(e => e.Fees_Type).HasComment("0. Per Month\r\n1. Per One\r\n2. Per Day");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_FeesBR>(entity =>
            {
                entity.HasKey(e => e.FBR_Guid);

                entity.ToTable("tbl_FeesBR");

                entity.Property(e => e.FBR_Guid).HasMaxLength(100);

                entity.Property(e => e.BR_Code).HasMaxLength(100);

                entity.Property(e => e.BR_Guid).HasMaxLength(100);

                entity.Property(e => e.BR_Type).HasComment("1. Building\r\n2. Room");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fees_Guid).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_File>(entity =>
            {
                entity.HasKey(e => e.File_Guid);

                entity.ToTable("tbl_File");

                entity.Property(e => e.File_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.File_Type).HasComment("1. File (pdf, doc, excel,...)\r\n2. Image (png, jpg)");

                entity.Property(e => e.File_URL).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Object_Guid).HasMaxLength(100);

                entity.Property(e => e.Object_Type).HasComment("1. ClientContract\r\n2. CustomerContract\r\n3. IDentify\r\n4. Building\r\n5. Room");
            });

            modelBuilder.Entity<tbl_MainCapacitor>(entity =>
            {
                entity.HasKey(e => e.MainCapacitor_Guid);

                entity.ToTable("tbl_MainCapacitor");

                entity.Property(e => e.MainCapacitor_Guid).HasMaxLength(100);

                entity.Property(e => e.Building_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_PaymentHistory>(entity =>
            {
                entity.HasKey(e => e.PaymentHistory_Guid);

                entity.ToTable("tbl_PaymentHistory");

                entity.Property(e => e.PaymentHistory_Guid).HasMaxLength(100);

                entity.Property(e => e.Account_Guid_Pay).HasMaxLength(100);

                entity.Property(e => e.Bill_Guid).HasMaxLength(100);

                entity.Property(e => e.Contract_Type).HasComment("1. Client Contract\r\n2. Customer Contract");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ObjContract_Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<tbl_RC>(entity =>
            {
                entity.HasKey(e => e.RC_Guid);

                entity.ToTable("tbl_RC");

                entity.Property(e => e.RC_Guid).HasMaxLength(100);

                entity.Property(e => e.Capacitor_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Room_Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<tbl_Room>(entity =>
            {
                entity.HasKey(e => e.Room_Guid);

                entity.ToTable("tbl_Room");

                entity.Property(e => e.Room_Guid).HasMaxLength(100);

                entity.Property(e => e.Building_Guid).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Room_Area_Unit).HasMaxLength(50);

                entity.Property(e => e.Room_Code).HasMaxLength(100);

                entity.Property(e => e.Room_Summary).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
