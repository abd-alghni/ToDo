﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.DbModel;

#nullable disable

namespace ToDo.DbModel.Migrations
{
    [DbContext(typeof(tododbContext))]
    partial class tododbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToDo.DbModel.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignedId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CreatedDateUtcTime")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("CreatedDate")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("''");

                    b.Property<byte>("IsArchived")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsRead")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("UpdatedDateUtcTime")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("UpdatedDate")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "Id_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "AssignedId" }, "fk_user_assigned_idx");

                    b.HasIndex(new[] { "CreatorId" }, "fk_user_todo_idx");

                    b.ToTable("todo", (string)null);
                });

            modelBuilder.Entity("ToDo.DbModel.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("CreatedDateUtcTime")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("CreatedDate")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Image")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("''");

                    b.Property<byte>("IsAdmin")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsArchived")
                        .HasColumnType("tinyint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("''");

                    b.Property<byte[]>("UpdatedDateUtcTime")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("UpdatedDate")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "Email_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "Id" }, "Id_UNIQUE")
                        .IsUnique()
                        .HasDatabaseName("Id_UNIQUE1");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("ToDo.DbModel.Models.Todo", b =>
                {
                    b.HasOne("ToDo.DbModel.Models.User", "Creator")
                        .WithMany("Todos")
                        .HasForeignKey("AssignedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_assigned");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("ToDo.DbModel.Models.User", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
