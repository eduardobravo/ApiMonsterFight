﻿// <auto-generated />
using System;
using Lib.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(BattleOfMonstersContext))]
    partial class BattleOfMonstersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Lib.Repository.Entities.Battle", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MonsterA")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MonsterB")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Winner")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MonsterA");

                    b.HasIndex("MonsterB");

                    b.HasIndex("Winner");

                    b.ToTable("Battle", (string)null);
                });

            modelBuilder.Entity("Lib.Repository.Entities.Monster", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Attack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Monster", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 60,
                            Defense = 40,
                            Hp = 10,
                            ImageUrl = "https://fsl-assessment-public-files.s3.amazonaws.com/assessment-cc-01/dead-unicorn.png",
                            Name = "Dead Unicorn",
                            Speed = 80
                        },
                        new
                        {
                            Id = 2,
                            Attack = 50,
                            Defense = 20,
                            Hp = 80,
                            ImageUrl = "https://fsl-assessment-public-files.s3.amazonaws.com/assessment-cc-01/old-shark.png",
                            Name = "Old Shark",
                            Speed = 90
                        },
                        new
                        {
                            Id = 3,
                            Attack = 90,
                            Defense = 80,
                            Hp = 90,
                            ImageUrl = "https://fsl-assessment-public-files.s3.amazonaws.com/assessment-cc-01/red-dragon.png",
                            Name = "Red Dragon",
                            Speed = 70
                        },
                        new
                        {
                            Id = 4,
                            Attack = 50,
                            Defense = 40,
                            Hp = 80,
                            ImageUrl = "https://fsl-assessment-public-files.s3.amazonaws.com/assessment-cc-01/robot-bear.png",
                            Name = "Robot Bear",
                            Speed = 60
                        },
                        new
                        {
                            Id = 5,
                            Attack = 80,
                            Defense = 20,
                            Hp = 70,
                            ImageUrl = "https://fsl-assessment-public-files.s3.amazonaws.com/assessment-cc-01/angry-snake.png",
                            Name = "Angry Snake",
                            Speed = 80
                        });
                });

            modelBuilder.Entity("Lib.Repository.Entities.Battle", b =>
                {
                    b.HasOne("Lib.Repository.Entities.Monster", "MonsterARelation")
                        .WithMany()
                        .HasForeignKey("MonsterA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.Repository.Entities.Monster", "MonsterBRelation")
                        .WithMany()
                        .HasForeignKey("MonsterB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.Repository.Entities.Monster", "WinnerRelation")
                        .WithMany()
                        .HasForeignKey("Winner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonsterARelation");

                    b.Navigation("MonsterBRelation");

                    b.Navigation("WinnerRelation");
                });
#pragma warning restore 612, 618
        }
    }
}
