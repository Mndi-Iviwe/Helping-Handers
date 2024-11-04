﻿// <auto-generated />
using System;
using Helping_Handers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Helping_Handers.Migrations
{
    [DbContext(typeof(Helping_HandDbContext))]
    [Migration("20241104180739_second migration")]
    partial class secondmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Helping_Handers.Areas.Identity.Data.Helping_Manager", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("helping_Manager");
                });

            modelBuilder.Entity("Helping_Handers.Areas.Identity.Data.Helping_User", b =>
                {
                    b.Property<int>("user_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_age")
                        .HasColumnType("int");

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_Id");

                    b.ToTable("helping_Users");
                });

            modelBuilder.Entity("Helping_Handers.Areas.Identity.Data.Helping_Volunteer", b =>
                {
                    b.Property<int>("vol_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vol_Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_assigned")
                        .HasColumnType("bit");

                    b.Property<int>("vol_age")
                        .HasColumnType("int");

                    b.Property<string>("vol_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vol_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vol_Id");

                    b.ToTable("helping_Volunteers");
                });

            modelBuilder.Entity("Helping_Handers.Models.Clothing", b =>
                {
                    b.Property<int>("clothe_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clothe_ID"));

                    b.Property<string>("clothe_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clothe_size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clothe_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clothe_ID");

                    b.ToTable("Clothes");
                });

            modelBuilder.Entity("Helping_Handers.Models.Food", b =>
                {
                    b.Property<int>("food_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("food_ID"));

                    b.Property<DateTime>("food_expiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("food_handling")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("food_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("food_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("food_ID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Helping_Handers.Models.IncidentAssignment", b =>
                {
                    b.Property<int>("assign_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("assign_ID"));

                    b.Property<DateTime>("assign_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("assign_role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("assign_ID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Helping_Handers.Models.IncidentReport", b =>
                {
                    b.Property<int>("incident_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("incident_ID"));

                    b.Property<int>("Num_volunteers")
                        .HasColumnType("int");

                    b.Property<string>("incident_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incident_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incident_magnitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incident_risk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("incident_ID");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Helping_Handers.Models.MedicalSupplies", b =>
                {
                    b.Property<int>("med_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("med_ID"));

                    b.Property<string>("med_manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("med_quant")
                        .HasColumnType("int");

                    b.Property<string>("med_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("med_ID");

                    b.ToTable("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
