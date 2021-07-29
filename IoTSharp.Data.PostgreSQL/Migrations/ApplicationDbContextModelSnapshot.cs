﻿// <auto-generated />
using System;
using IoTSharp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IoTSharp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("IoTSharp.Data.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ActionData")
                        .HasColumnType("jsonb");

                    b.Property<string>("ActionName")
                        .HasColumnType("text");

                    b.Property<string>("ActionResult")
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("ActiveDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ObjectID")
                        .HasColumnType("uuid");

                    b.Property<string>("ObjectName")
                        .HasColumnType("text");

                    b.Property<int>("ObjectType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TenantId");

                    b.ToTable("AuditLog");
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthToken")
                        .HasColumnType("text");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TenantId");

                    b.ToTable("AuthorizedKeys");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("IoTSharp.Data.DataStorage", b =>
                {
                    b.Property<int>("Catalog")
                        .HasColumnType("integer");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uuid");

                    b.Property<string>("KeyName")
                        .HasColumnType("text");

                    b.Property<int>("DataSide")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<byte[]>("Value_Binary")
                        .HasColumnType("bytea");

                    b.Property<bool>("Value_Boolean")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Value_DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Value_Double")
                        .HasColumnType("double precision");

                    b.Property<string>("Value_Json")
                        .HasColumnType("jsonb");

                    b.Property<long>("Value_Long")
                        .HasColumnType("bigint");

                    b.Property<string>("Value_String")
                        .HasColumnType("text");

                    b.Property<string>("Value_XML")
                        .HasColumnType("xml");

                    b.HasKey("Catalog", "DeviceId", "KeyName");

                    b.HasIndex("Catalog");

                    b.HasIndex("Catalog", "DeviceId");

                    b.ToTable("DataStorage");

                    b.HasDiscriminator<int>("Catalog").HasValue(0);
                });

            modelBuilder.Entity("IoTSharp.Data.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AuthorizedKeyId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<int>("DeviceType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Online")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<int>("Timeout")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizedKeyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TenantId");

                    b.ToTable("Device");

                    b.HasDiscriminator<int>("DeviceType").HasValue(0);
                });

            modelBuilder.Entity("IoTSharp.Data.DeviceIdentity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("uuid");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdentityType")
                        .HasColumnType("integer");

                    b.Property<string>("IdentityValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("DeviceIdentities");
                });

            modelBuilder.Entity("IoTSharp.Data.Flow", b =>
                {
                    b.Property<long>("FlowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Conditionexpression")
                        .HasColumnType("text");

                    b.Property<string>("FlowType")
                        .HasColumnType("text");

                    b.Property<string>("Flowdesc")
                        .HasColumnType("text");

                    b.Property<string>("Flowname")
                        .HasColumnType("text");

                    b.Property<string>("Incoming")
                        .HasColumnType("text");

                    b.Property<string>("NodeProcessClass")
                        .HasColumnType("text");

                    b.Property<string>("NodeProcessMethod")
                        .HasColumnType("text");

                    b.Property<string>("NodeProcessParams")
                        .HasColumnType("text");

                    b.Property<string>("NodeProcessScript")
                        .HasColumnType("text");

                    b.Property<string>("NodeProcessType")
                        .HasColumnType("text");

                    b.Property<string>("ObjectId")
                        .HasColumnType("text");

                    b.Property<string>("Outgoing")
                        .HasColumnType("text");

                    b.Property<long>("RuleId")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceId")
                        .HasColumnType("text");

                    b.Property<string>("TargetId")
                        .HasColumnType("text");

                    b.Property<string>("bpmnid")
                        .HasColumnType("text");

                    b.HasKey("FlowId");

                    b.ToTable("Flows");
                });

            modelBuilder.Entity("IoTSharp.Data.FlowOperation", b =>
                {
                    b.Property<long>("OperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("AddDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("BizId")
                        .HasColumnType("text");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<long>("FlowId")
                        .HasColumnType("bigint");

                    b.Property<int?>("NodeStatus")
                        .HasColumnType("integer");

                    b.Property<string>("OperationDesc")
                        .HasColumnType("text");

                    b.Property<long>("RuleId")
                        .HasColumnType("bigint");

                    b.HasKey("OperationId");

                    b.ToTable("FlowOperations");
                });

            modelBuilder.Entity("IoTSharp.Data.FlowRule", b =>
                {
                    b.Property<long>("RuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Creator")
                        .HasColumnType("text");

                    b.Property<string>("DefinitionsXml")
                        .HasColumnType("text");

                    b.Property<string>("Describes")
                        .HasColumnType("text");

                    b.Property<string>("ExecutableCode")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RuleDesc")
                        .HasColumnType("text");

                    b.Property<int?>("RuleStatus")
                        .HasColumnType("integer");

                    b.Property<int>("RuleType")
                        .HasColumnType("integer");

                    b.Property<string>("Runner")
                        .HasColumnType("text");

                    b.HasKey("RuleId");

                    b.ToTable("FlowRules");
                });

            modelBuilder.Entity("IoTSharp.Data.Relationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("text");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("TenantId");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("IoTSharp.Data.TelemetryData", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uuid");

                    b.Property<string>("KeyName")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DataSide")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<byte[]>("Value_Binary")
                        .HasColumnType("bytea");

                    b.Property<bool>("Value_Boolean")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Value_DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Value_Double")
                        .HasColumnType("double precision");

                    b.Property<string>("Value_Json")
                        .HasColumnType("jsonb");

                    b.Property<long>("Value_Long")
                        .HasColumnType("bigint");

                    b.Property<string>("Value_String")
                        .HasColumnType("text");

                    b.Property<string>("Value_XML")
                        .HasColumnType("xml");

                    b.HasKey("DeviceId", "KeyName", "DateTime");

                    b.HasIndex("DeviceId");

                    b.HasIndex("KeyName");

                    b.HasIndex("DeviceId", "KeyName");

                    b.ToTable("TelemetryData");
                });

            modelBuilder.Entity("IoTSharp.Data.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("EMail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IoTSharp.Data.AttributeLatest", b =>
                {
                    b.HasBaseType("IoTSharp.Data.DataStorage");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("IoTSharp.Data.TelemetryLatest", b =>
                {
                    b.HasBaseType("IoTSharp.Data.DataStorage");

                    b.HasDiscriminator().HasValue(4);
                });

            modelBuilder.Entity("IoTSharp.Data.Gateway", b =>
                {
                    b.HasBaseType("IoTSharp.Data.Device");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("IoTSharp.Data.AuditLog", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany("Customers")
                        .HasForeignKey("TenantId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.Device", b =>
                {
                    b.HasOne("IoTSharp.Data.AuthorizedKey", null)
                        .WithMany("Devices")
                        .HasForeignKey("AuthorizedKeyId");

                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany("Devices")
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Gateway", "Owner")
                        .WithMany("Children")
                        .HasForeignKey("OwnerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany("Devices")
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Owner");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.DeviceIdentity", b =>
                {
                    b.HasOne("IoTSharp.Data.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("IoTSharp.Data.Relationship", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("IdentityUser");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Tenant", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Gateway", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
