﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SagasMicroservice.Migrations
{
    [DbContext(typeof(SagasDbContext))]
    [Migration("20220509202248_AddRequestAddress")]
    partial class AddRequestAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BuyItemsSagaState", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uuid");

                    b.Property<string>("CurrentState")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RequestId")
                        .HasColumnType("uuid");

                    b.Property<string>("ResponseAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CorrelationId");

                    b.ToTable("BuyItemsSagaState");
                });
#pragma warning restore 612, 618
        }
    }
}
