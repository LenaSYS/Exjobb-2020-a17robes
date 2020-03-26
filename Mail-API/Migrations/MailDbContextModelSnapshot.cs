﻿// <auto-generated />
using System;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mail_API.Migrations
{
    [DbContext(typeof(MailDbContext))]
    partial class MailDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mail_API.Models.Db.Mail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "FirstBody",
                            CreatedTime = new DateTime(2020, 3, 26, 15, 2, 50, 846, DateTimeKind.Local).AddTicks(9377),
                            ExternalId = "Test1",
                            IPAddress = "FirstIPAddress",
                            OpenTime = new DateTime(2020, 3, 26, 15, 2, 50, 852, DateTimeKind.Local).AddTicks(9616),
                            Receiver = "FirstReceiver",
                            ReplyTo = "FirstReplyTo",
                            Sender = "FirstSender",
                            SentTime = new DateTime(2020, 3, 26, 15, 2, 50, 852, DateTimeKind.Local).AddTicks(4510),
                            Status = 0,
                            Subject = "FirstSubject",
                            TrackerId = "FirstTrackerId"
                        },
                        new
                        {
                            Id = 2,
                            Body = "SecondBody",
                            CreatedTime = new DateTime(2020, 3, 26, 15, 2, 50, 853, DateTimeKind.Local).AddTicks(3286),
                            ExternalId = "Test2",
                            IPAddress = "SecondIPAddress",
                            OpenTime = new DateTime(2020, 3, 26, 15, 2, 50, 853, DateTimeKind.Local).AddTicks(3340),
                            Receiver = "SecondReceiver",
                            ReplyTo = "SecondReplyTo",
                            Sender = "SecondSender",
                            SentTime = new DateTime(2020, 3, 26, 15, 2, 50, 853, DateTimeKind.Local).AddTicks(3312),
                            Status = 0,
                            Subject = "SecondSubject",
                            TrackerId = "SecondTrackerId"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
