﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hienv_asp.Context;

#nullable disable

namespace hienv_asp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230808041704_V0")]
    partial class V0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hienv_asp.Models.ErrorViewModel", b =>
                {
                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ErrorViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}
