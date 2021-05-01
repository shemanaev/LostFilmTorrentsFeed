﻿// <auto-generated />
using System;
using LostFilmMonitoring.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LostFilmMonitoring.DAO.Migrations
{
    [DbContext(typeof(LostFilmDbContext))]
    [Migration("20201207145632_Init")]
    partial class Init
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.Serial", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastEpisode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastEpisodeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastEpisodeTorrentLink1080")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastEpisodeTorrentLinkMP4")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastEpisodeTorrentLinkSD")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Serials");
                });

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.Setting", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.Subscription", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Serial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quality")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "Serial");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cookie")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActivity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Usess")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.Subscription", b =>
                {
                    b.HasOne("LostFilmMonitoring.DAO.DomainModels.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Subscriptions_Users")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LostFilmMonitoring.DAO.DomainModels.User", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
