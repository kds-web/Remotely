﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Remotely.Server.Data;

namespace Remotely.Server.Migrations.PostgreSql
{
    [DbContext(typeof(PostgreSqlDbContext))]
    [Migration("20210210030835_Change BrandingInfo Id")]
    partial class ChangeBrandingInfoId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DeviceGroupRemotelyUser", b =>
                {
                    b.Property<string>("DeviceGroupsID")
                        .HasColumnType("text");

                    b.Property<string>("UsersId")
                        .HasColumnType("text");

                    b.HasKey("DeviceGroupsID", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("DeviceGroupRemotelyUser");
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
                        .UseIdentityByDefaultColumn();

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

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.ToTable("RemotelyUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

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
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Alert", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeviceID")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("UserID");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("Remotely.Shared.Models.ApiToken", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("LastUsed")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Secret")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("Token");

                    b.ToTable("ApiTokens");
                });

            modelBuilder.Entity("Remotely.Shared.Models.BrandingInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<byte>("ButtonForegroundBlue")
                        .HasColumnType("smallint");

                    b.Property<byte>("ButtonForegroundGreen")
                        .HasColumnType("smallint");

                    b.Property<byte>("ButtonForegroundRed")
                        .HasColumnType("smallint");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("bytea");

                    b.Property<string>("Product")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<byte>("TitleBackgroundBlue")
                        .HasColumnType("smallint");

                    b.Property<byte>("TitleBackgroundGreen")
                        .HasColumnType("smallint");

                    b.Property<byte>("TitleBackgroundRed")
                        .HasColumnType("smallint");

                    b.Property<byte>("TitleForegroundBlue")
                        .HasColumnType("smallint");

                    b.Property<byte>("TitleForegroundGreen")
                        .HasColumnType("smallint");

                    b.Property<byte>("TitleForegroundRed")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("BrandingInfo");
                });

            modelBuilder.Entity("Remotely.Shared.Models.CommandResult", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("CommandMode")
                        .HasColumnType("text");

                    b.Property<string>("CommandResults")
                        .HasColumnType("text");

                    b.Property<string>("CommandText")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("PSCoreResults")
                        .HasColumnType("text");

                    b.Property<string>("SenderConnectionID")
                        .HasColumnType("text");

                    b.Property<string>("SenderUserID")
                        .HasColumnType("text");

                    b.Property<string>("TargetDeviceIDs")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("CommandResults");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Device", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("AgentVersion")
                        .HasColumnType("text");

                    b.Property<string>("Alias")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<double>("CpuUtilization")
                        .HasColumnType("double precision");

                    b.Property<string>("CurrentUser")
                        .HasColumnType("text");

                    b.Property<string>("DeviceGroupID")
                        .HasColumnType("text");

                    b.Property<string>("DeviceName")
                        .HasColumnType("text");

                    b.Property<string>("Drives")
                        .HasColumnType("text");

                    b.Property<bool>("Is64Bit")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("LastOnline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("OSArchitecture")
                        .HasColumnType("integer");

                    b.Property<string>("OSDescription")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Platform")
                        .HasColumnType("text");

                    b.Property<int>("ProcessorCount")
                        .HasColumnType("integer");

                    b.Property<string>("PublicIP")
                        .HasColumnType("text");

                    b.Property<string>("ServerVerificationToken")
                        .HasColumnType("text");

                    b.Property<string>("Tags")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<double>("TotalMemory")
                        .HasColumnType("double precision");

                    b.Property<double>("TotalStorage")
                        .HasColumnType("double precision");

                    b.Property<double>("UsedMemory")
                        .HasColumnType("double precision");

                    b.Property<double>("UsedStorage")
                        .HasColumnType("double precision");

                    b.Property<int>("WebRtcSetting")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("DeviceGroupID");

                    b.HasIndex("DeviceName");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Remotely.Shared.Models.DeviceGroup", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("DeviceGroups");
                });

            modelBuilder.Entity("Remotely.Shared.Models.EventLog", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<string>("StackTrace")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("Remotely.Shared.Models.InviteLink", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("DateSent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InvitedUser")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("ResetUrl")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("InviteLinks");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Organization", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("BrandingInfoId")
                        .HasColumnType("text");

                    b.Property<string>("GithubUser")
                        .HasColumnType("text");

                    b.Property<bool>("IsDefaultOrganization")
                        .HasColumnType("boolean");

                    b.Property<string>("OrganizationName")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("RelayCode")
                        .HasColumnType("text");

                    b.Property<double>("SponsorAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("UnlockCode")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("BrandingInfoId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Remotely.Shared.Models.SharedFile", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("ContentType")
                        .HasColumnType("text");

                    b.Property<byte[]>("FileContents")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("SharedFiles");
                });

            modelBuilder.Entity("Remotely.Shared.Models.RemotelyUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsServerAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("TempPassword")
                        .HasColumnType("text");

                    b.Property<string>("UserOptions")
                        .HasColumnType("text");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("UserName");

                    b.HasDiscriminator().HasValue("RemotelyUser");
                });

            modelBuilder.Entity("DeviceGroupRemotelyUser", b =>
                {
                    b.HasOne("Remotely.Shared.Models.DeviceGroup", null)
                        .WithMany()
                        .HasForeignKey("DeviceGroupsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Remotely.Shared.Models.RemotelyUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Remotely.Shared.Models.Alert", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Device", "Device")
                        .WithMany("Alerts")
                        .HasForeignKey("DeviceID");

                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("Alerts")
                        .HasForeignKey("OrganizationID");

                    b.HasOne("Remotely.Shared.Models.RemotelyUser", "User")
                        .WithMany("Alerts")
                        .HasForeignKey("UserID");

                    b.Navigation("Device");

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Remotely.Shared.Models.ApiToken", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("ApiTokens")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.CommandResult", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("CommandResults")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Device", b =>
                {
                    b.HasOne("Remotely.Shared.Models.DeviceGroup", "DeviceGroup")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceGroupID");

                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("Devices")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("DeviceGroup");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.DeviceGroup", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("DeviceGroups")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.EventLog", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("EventLogs")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.InviteLink", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("InviteLinks")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Organization", b =>
                {
                    b.HasOne("Remotely.Shared.Models.BrandingInfo", "BrandingInfo")
                        .WithMany()
                        .HasForeignKey("BrandingInfoId");

                    b.Navigation("BrandingInfo");
                });

            modelBuilder.Entity("Remotely.Shared.Models.SharedFile", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("SharedFiles")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.RemotelyUser", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("RemotelyUsers")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Device", b =>
                {
                    b.Navigation("Alerts");
                });

            modelBuilder.Entity("Remotely.Shared.Models.DeviceGroup", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Organization", b =>
                {
                    b.Navigation("Alerts");

                    b.Navigation("ApiTokens");

                    b.Navigation("CommandResults");

                    b.Navigation("DeviceGroups");

                    b.Navigation("Devices");

                    b.Navigation("EventLogs");

                    b.Navigation("InviteLinks");

                    b.Navigation("RemotelyUsers");

                    b.Navigation("SharedFiles");
                });

            modelBuilder.Entity("Remotely.Shared.Models.RemotelyUser", b =>
                {
                    b.Navigation("Alerts");
                });
#pragma warning restore 612, 618
        }
    }
}