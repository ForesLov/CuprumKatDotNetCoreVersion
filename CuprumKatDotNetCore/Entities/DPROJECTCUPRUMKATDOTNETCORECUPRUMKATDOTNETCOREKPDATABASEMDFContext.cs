using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CuprumKatDotNetCore.Entities
{
    public partial class DPROJECTCUPRUMKATDOTNETCORECUPRUMKATDOTNETCOREKPDATABASEMDFContext : DbContext
    {
        public DPROJECTCUPRUMKATDOTNETCORECUPRUMKATDOTNETCOREKPDATABASEMDFContext()
        {
        }

        public DPROJECTCUPRUMKATDOTNETCORECUPRUMKATDOTNETCOREKPDATABASEMDFContext(DbContextOptions<DPROJECTCUPRUMKATDOTNETCORECUPRUMKATDOTNETCOREKPDATABASEMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AuthD> AuthDs { get; set; } = null!;
        public virtual DbSet<CompanyPose> CompanyPoses { get; set; } = null!;
        public virtual DbSet<DeliveryView> DeliveryViews { get; set; } = null!;
        public virtual DbSet<EDelivery> EDeliveries { get; set; } = null!;
        public virtual DbSet<IsUser> IsUsers { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductView> ProductViews { get; set; } = null!;
        public virtual DbSet<ProductWriteOff> ProductWriteOffs { get; set; } = null!;
        public virtual DbSet<Storehouse> Storehouses { get; set; } = null!;
        public virtual DbSet<WriteOff> WriteOffs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Project\\CuprumKatDotNetCore\\CuprumKatDotNetCore\\KPDatabase.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount)
                    .HasName("PK__Account__213379EB8FF69565");

                entity.ToTable("Account");

                entity.Property(e => e.IdAccount).HasColumnName("ID_Account");

                entity.Property(e => e.ULog)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Log");

                entity.Property(e => e.UPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("U_Pass");
            });

            modelBuilder.Entity<AuthD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Auth_D");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.PoseName)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Pose_Name");

                entity.Property(e => e.UAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("U_Address");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("U_Email");

                entity.Property(e => e.ULname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_LName");

                entity.Property(e => e.ULog)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Log");

                entity.Property(e => e.UName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Name");

                entity.Property(e => e.UPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("U_Pass");

                entity.Property(e => e.USname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_SName");

                entity.Property(e => e.UphoneNumber)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("UPhone_Number");
            });

            modelBuilder.Entity<CompanyPose>(entity =>
            {
                entity.HasKey(e => e.IdPose)
                    .HasName("PK__CompanyP__B41D0E3F97AACB5F");

                entity.ToTable("CompanyPose");

                entity.Property(e => e.IdPose).HasColumnName("ID_Pose");

                entity.Property(e => e.PoseName)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Pose_Name");
            });

            modelBuilder.Entity<DeliveryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Delivery_View");

                entity.Property(e => e.DelivAmount).HasColumnName("Deliv_Amount");

                entity.Property(e => e.DelivCost)
                    .HasColumnType("money")
                    .HasColumnName("Deliv_Cost");

                entity.Property(e => e.DelivDate)
                    .HasColumnType("date")
                    .HasColumnName("Deliv_Date");

                entity.Property(e => e.IdDeliv).HasColumnName("ID_Deliv");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ULname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_LName");

                entity.Property(e => e.UName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Name");

                entity.Property(e => e.USname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_SName");
            });

            modelBuilder.Entity<EDelivery>(entity =>
            {
                entity.HasKey(e => e.IdDeliv)
                    .HasName("PK__E_Delive__E9AD3DCCE409214A");

                entity.ToTable("E_Delivery");

                entity.Property(e => e.IdDeliv).HasColumnName("ID_Deliv");

                entity.Property(e => e.DelivAmount).HasColumnName("Deliv_Amount");

                entity.Property(e => e.DelivCost)
                    .HasColumnType("money")
                    .HasColumnName("Deliv_Cost");

                entity.Property(e => e.DelivDate)
                    .HasColumnType("date")
                    .HasColumnName("Deliv_Date");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.ManufId).HasColumnName("Manuf_Id");

                entity.Property(e => e.UId).HasColumnName("U_Id");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.EDeliveries)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK__E_Deliver__Id_Pr__46E78A0C");

                entity.HasOne(d => d.Manuf)
                    .WithMany(p => p.EDeliveries)
                    .HasForeignKey(d => d.ManufId)
                    .HasConstraintName("FK__E_Deliver__Manuf__47DBAE45");

                entity.HasOne(d => d.UIdNavigation)
                    .WithMany(p => p.EDeliveries)
                    .HasForeignKey(d => d.UId)
                    .HasConstraintName("FK__E_Delivery__U_Id__48CFD27E");
            });

            modelBuilder.Entity<IsUser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__IS_User__D03DEDCB039BD6B9");

                entity.ToTable("IS_User");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.IdPose).HasColumnName("ID_Pose");

                entity.Property(e => e.IdUAccount).HasColumnName("ID_U_Account");

                entity.Property(e => e.UAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("U_Address");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("U_Email");

                entity.Property(e => e.ULname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_LName");

                entity.Property(e => e.UName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Name");

                entity.Property(e => e.USname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_SName");

                entity.Property(e => e.UphoneNumber)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("UPhone_Number");

                entity.HasOne(d => d.IdPoseNavigation)
                    .WithMany(p => p.IsUsers)
                    .HasForeignKey(d => d.IdPose)
                    .HasConstraintName("FK__IS_User__ID_Pose__3D5E1FD2");

                entity.HasOne(d => d.IdUAccountNavigation)
                    .WithMany(p => p.IsUsers)
                    .HasForeignKey(d => d.IdUAccount)
                    .HasConstraintName("FK__IS_User__ID_U_Ac__3C69FB99");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufId)
                    .HasName("PK__Manufact__4924A5F0DF8A70AB");

                entity.ToTable("Manufacturer");

                entity.Property(e => e.ManufId).HasColumnName("Manuf_Id");

                entity.Property(e => e.CeoLname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CEO_LName");

                entity.Property(e => e.CeoName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CEO_Name");

                entity.Property(e => e.CeoSname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CEO_SName");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Inn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INN");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("KPP");

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("OGRN");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("OKPO");

                entity.Property(e => e.Okved)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OKVED");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.RepresLname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Repres_LName");

                entity.Property(e => e.RespersName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Respers_Name");

                entity.Property(e => e.RespersPhone)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Respers_Phone");

                entity.Property(e => e.RespersPose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Respers_Pose");

                entity.Property(e => e.RespersSname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Respers_SName");

                entity.Property(e => e.UrAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ur_Address");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK__Product__522DE49689651FA4");

                entity.ToTable("Product");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.IdManfc).HasColumnName("id_manfc");

                entity.Property(e => e.IdStore).HasColumnName("ID_Store");

                entity.Property(e => e.ProductAmount).HasColumnName("Product_amount");

                entity.Property(e => e.ProductMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product_Measure");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("money")
                    .HasColumnName("Product_Price");

                entity.HasOne(d => d.IdManfcNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdManfc)
                    .HasConstraintName("FK__Product__id_manf__4316F928");

                entity.HasOne(d => d.IdStoreNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdStore)
                    .HasConstraintName("FK__Product__ID_Stor__4222D4EF");
            });

            modelBuilder.Entity<ProductView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Product_View");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Name");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.ProductAmount).HasColumnName("Product_amount");

                entity.Property(e => e.ProductMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product_Measure");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("money")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.StorePurpose)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductWriteOff>(entity =>
            {
                entity.HasKey(e => e.IdOff)
                    .HasName("PK__Product___20E8F8A2B4C67E86");

                entity.ToTable("Product_Write_off");

                entity.Property(e => e.IdOff).HasColumnName("ID_Off");

                entity.Property(e => e.AmountOff).HasColumnName("Amount_Off");

                entity.Property(e => e.CostOff)
                    .HasColumnType("money")
                    .HasColumnName("Cost_Off");

                entity.Property(e => e.DateOff)
                    .HasColumnType("date")
                    .HasColumnName("Date_Off");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.UId).HasColumnName("U_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductWriteOffs)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Product_W__Produ__4BAC3F29");

                entity.HasOne(d => d.UIdNavigation)
                    .WithMany(p => p.ProductWriteOffs)
                    .HasForeignKey(d => d.UId)
                    .HasConstraintName("FK__Product_Wr__U_Id__4CA06362");
            });

            modelBuilder.Entity<Storehouse>(entity =>
            {
                entity.HasKey(e => e.IdStore)
                    .HasName("PK__Storehou__99D83D2CBCB82F3D");

                entity.ToTable("Storehouse");

                entity.Property(e => e.IdStore).HasColumnName("ID_Store");

                entity.Property(e => e.StorePurpose)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WriteOff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Write_off");

                entity.Property(e => e.AmountOff).HasColumnName("Amount_Off");

                entity.Property(e => e.CostOff)
                    .HasColumnType("money")
                    .HasColumnName("Cost_Off");

                entity.Property(e => e.DateOff)
                    .HasColumnType("date")
                    .HasColumnName("Date_Off");

                entity.Property(e => e.IdOff).HasColumnName("ID_Off");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ULname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_LName");

                entity.Property(e => e.UName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_Name");

                entity.Property(e => e.USname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("U_SName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
