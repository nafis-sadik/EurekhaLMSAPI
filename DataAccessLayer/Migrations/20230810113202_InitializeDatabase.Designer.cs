﻿// <auto-generated />
using System;
using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(RedbookInventoryContext))]
    [Migration("20230810113202_InitializeDatabase")]
    partial class InitializeDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Data.Entities.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankId"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("BankId")
                        .HasName("PK__Bank__3214EC07A30FEA48");

                    b.ToTable("Bank", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("BranchId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("BranchId");

                    b.HasIndex("BankId");

                    b.ToTable("BankBranch", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCategory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inventory.Data.Entities.CommonAttribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AttributeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("AttributeId")
                        .HasName("PK__CommonAt__3214EC0712D1E7C6");

                    b.ToTable("CommonAttribute", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("Inventory", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.OrganizationCache", b =>
                {
                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("OrganizationId");

                    b.ToTable("OrganizationCache", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreateBy");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("QuantityAttributeId");

                    b.HasIndex("UpdateBy");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CheckNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("PurchasedBy")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPurchasePrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("PurchaseId");

                    b.HasIndex("AccountId");

                    b.ToTable("Purchase", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseDetail", b =>
                {
                    b.Property<int>("PurchaseDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseDetailsId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("PurchaseDetailsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePayment", b =>
                {
                    b.Property<int>("PurchasePaymentId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.HasKey("PurchasePaymentId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchasePayments");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesId"));

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("SoldBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("SalesId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesDetail", b =>
                {
                    b.Property<int>("SalesDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesDetailsId"));

                    b.Property<string>("ChalanNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.Property<int>("SoldBy")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("SalesDetailsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesId");

                    b.HasIndex("SoldBy");

                    b.ToTable("SalesDetails");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesPaymentRecord", b =>
                {
                    b.Property<int>("SalesPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesPaymentId"));

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.HasKey("SalesPaymentId");

                    b.HasIndex("SalesId");

                    b.ToTable("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.UserCache", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserCache", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.HasOne("Inventory.Data.Entities.BankBranch", "Branch")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BranchId")
                        .IsRequired()
                        .HasConstraintName("FK_BankAccounts_BankBranch");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .IsRequired()
                        .HasConstraintName("FK_BankBranches_Banks");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.HasOne("Inventory.Data.Entities.UserCache", "CreatedByNavigation")
                        .WithMany("CategoryCreatedByNavigations")
                        .HasForeignKey("CreatedBy")
                        .IsRequired()
                        .HasConstraintName("FK_Categories_UserCache");

                    b.HasOne("Inventory.Data.Entities.UserCache", "UpdatedByNavigation")
                        .WithMany("CategoryUpdatedByNavigations")
                        .HasForeignKey("UpdatedBy")
                        .HasConstraintName("FK_Categories_UserCache1");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("UpdatedByNavigation");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Inventory", b =>
                {
                    b.HasOne("Inventory.Data.Entities.OrganizationCache", "Organization")
                        .WithMany("Inventories")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_Inventory_OrganizationCache");

                    b.HasOne("Inventory.Data.Entities.Purchase", "Purchase")
                        .WithMany("Inventories")
                        .HasForeignKey("PurchaseId")
                        .IsRequired()
                        .HasConstraintName("FK_Inventory_Purchase");

                    b.Navigation("Organization");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("Inventory.Data.Entities.UserCache", "CreateByNavigation")
                        .WithMany("ProductCreateByNavigations")
                        .HasForeignKey("CreateBy")
                        .IsRequired()
                        .HasConstraintName("FK_Products_UserCache1");

                    b.HasOne("Inventory.Data.Entities.OrganizationCache", "Organization")
                        .WithMany("Products")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_Products_OrganizationCache");

                    b.HasOne("Inventory.Data.Entities.CommonAttribute", "QuantityAttribute")
                        .WithMany("Products")
                        .HasForeignKey("QuantityAttributeId")
                        .IsRequired()
                        .HasConstraintName("FK_Products_CommonAttribute");

                    b.HasOne("Inventory.Data.Entities.UserCache", "UpdateByNavigation")
                        .WithMany("ProductUpdateByNavigations")
                        .HasForeignKey("UpdateBy")
                        .HasConstraintName("FK_Products_UserCache");

                    b.Navigation("Category");

                    b.Navigation("CreateByNavigation");

                    b.Navigation("Organization");

                    b.Navigation("QuantityAttribute");

                    b.Navigation("UpdateByNavigation");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Purchase", b =>
                {
                    b.HasOne("Inventory.Data.Entities.BankAccount", "Account")
                        .WithMany("Purchases")
                        .HasForeignKey("AccountId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_BankAccounts");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseDetail", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Products");

                    b.HasOne("Inventory.Data.Entities.Purchase", "Purchase")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Purchase");

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePayment", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Purchase", "Purchase")
                        .WithMany("PurchasePayments")
                        .HasForeignKey("PurchaseId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchasePayments_Purchase");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesDetail", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("SalesDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Products");

                    b.HasOne("Inventory.Data.Entities.Sale", "Sales")
                        .WithMany("SalesDetails")
                        .HasForeignKey("SalesId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Sales");

                    b.HasOne("Inventory.Data.Entities.UserCache", "SoldByNavigation")
                        .WithMany("SalesDetails")
                        .HasForeignKey("SoldBy")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_UserCache");

                    b.Navigation("Product");

                    b.Navigation("Sales");

                    b.Navigation("SoldByNavigation");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesPaymentRecord", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Sale", "Sales")
                        .WithMany("SalesPaymentRecords")
                        .HasForeignKey("SalesId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesPaymentRecords_Sales");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Bank", b =>
                {
                    b.Navigation("BankBranches");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.Navigation("BankAccounts");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.CommonAttribute", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.OrganizationCache", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.Navigation("PurchaseDetails");

                    b.Navigation("SalesDetails");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Purchase", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("PurchaseDetails");

                    b.Navigation("PurchasePayments");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.Navigation("SalesDetails");

                    b.Navigation("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.UserCache", b =>
                {
                    b.Navigation("CategoryCreatedByNavigations");

                    b.Navigation("CategoryUpdatedByNavigations");

                    b.Navigation("ProductCreateByNavigations");

                    b.Navigation("ProductUpdateByNavigations");

                    b.Navigation("SalesDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
