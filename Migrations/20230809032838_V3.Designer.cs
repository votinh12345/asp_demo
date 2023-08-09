﻿// <auto-generated />
using System;
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
    [Migration("20230809032838_V3")]
    partial class V3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hienv_asp.Models.Address", b =>
                {
                    b.Property<int>("address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("address_id"));

                    b.Property<string>("address_1")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("address_2")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("company")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("postcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("zone_id")
                        .HasColumnType("int");

                    b.HasKey("address_id");

                    b.HasIndex(new[] { "customer_id" }, "idx_customer_id");

                    b.ToTable("address");
                });

            modelBuilder.Entity("hienv_asp.Models.Affiliate", b =>
                {
                    b.Property<int>("affiliate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("affiliate_id"));

                    b.Property<string>("address_1")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("address_2")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<short>("approved")
                        .HasColumnType("smallint");

                    b.Property<string>("bank_account_name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("bank_account_number")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("bank_branch_number")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("bank_name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("bank_swift_code")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("cheque")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<decimal>("commission")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("company")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_added")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(96)
                        .HasColumnType("nvarchar(96)");

                    b.Property<string>("fax")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("ip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("payment")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("paypal")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("postcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<short>("status")
                        .HasColumnType("smallint");

                    b.Property<string>("tax")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<int>("zone_id")
                        .HasColumnType("int");

                    b.HasKey("affiliate_id");

                    b.ToTable("affiliate");
                });

            modelBuilder.Entity("hienv_asp.Models.AffiliateTransaction", b =>
                {
                    b.Property<int>("affiliate_transaction_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("affiliate_transaction_id"));

                    b.Property<int>("affiliate_id")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasPrecision(15, 4)
                        .HasColumnType("decimal(15,4)");

                    b.Property<DateTime?>("date_added")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.HasKey("affiliate_transaction_id");

                    b.ToTable("affiliate_transaction");
                });

            modelBuilder.Entity("hienv_asp.Models.AttributeDescription", b =>
                {
                    b.Property<int>("attribute_id")
                        .HasColumnType("int");

                    b.Property<int>("language_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("attribute_id", "language_id");

                    b.ToTable("attribute_description");
                });

            modelBuilder.Entity("hienv_asp.Models.AttributeGroup", b =>
                {
                    b.Property<int>("attribute_group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("attribute_group_id"));

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.HasKey("attribute_group_id");

                    b.ToTable("attribute_group");
                });

            modelBuilder.Entity("hienv_asp.Models.AttributeGroupDescription", b =>
                {
                    b.Property<int>("attribute_group_id")
                        .HasColumnType("int");

                    b.Property<int>("language_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("attribute_group_id", "language_id");

                    b.ToTable("attribute_group_description");
                });

            modelBuilder.Entity("hienv_asp.Models.Attributes", b =>
                {
                    b.Property<int>("attribute_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("attribute_id"));

                    b.Property<int>("attribute_group_id")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.HasKey("attribute_id");

                    b.ToTable("attribute");
                });

            modelBuilder.Entity("hienv_asp.Models.Banner", b =>
                {
                    b.Property<int>("banner_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("banner_id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<short>("status")
                        .HasColumnType("smallint");

                    b.HasKey("banner_id");

                    b.ToTable("banner");
                });

            modelBuilder.Entity("hienv_asp.Models.BannerImage", b =>
                {
                    b.Property<int>("banner_image_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("banner_image_id"));

                    b.Property<int>("banner_id")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.HasKey("banner_image_id");

                    b.ToTable("banner_image");
                });

            modelBuilder.Entity("hienv_asp.Models.BannerImageDescription", b =>
                {
                    b.Property<int>("banner_image_id")
                        .HasColumnType("int");

                    b.Property<int>("language_id")
                        .HasColumnType("int");

                    b.Property<int>("banner_id")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("banner_image_id", "language_id");

                    b.ToTable("banner_image_description");
                });

            modelBuilder.Entity("hienv_asp.Models.Blogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(191)
                        .HasColumnType("nvarchar(191)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("hienv_asp.Models.CategoriesDescription", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("language_id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meta_description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("meta_keyword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("name")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.HasKey("category_id", "language_id");

                    b.HasIndex(new[] { "name" }, "idx_categories_name_zen");

                    b.ToTable("category_description");
                });

            modelBuilder.Entity("hienv_asp.Models.Category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_id"));

                    b.Property<int>("column")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_added")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("parent_id")
                        .HasColumnType("int");

                    b.Property<int?>("sort_order")
                        .HasColumnType("int");

                    b.Property<short>("status")
                        .HasColumnType("smallint");

                    b.Property<int>("top")
                        .HasColumnType("int");

                    b.HasKey("category_id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("hienv_asp.Models.CategoryToLayout", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("store_id")
                        .HasColumnType("int");

                    b.Property<int>("layout_id")
                        .HasColumnType("int");

                    b.HasKey("category_id", "store_id");

                    b.ToTable("category_to_layout");
                });

            modelBuilder.Entity("hienv_asp.Models.CategoryToStore", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("store_id")
                        .HasColumnType("int");

                    b.HasKey("category_id", "store_id");

                    b.ToTable("category_to_store");
                });

            modelBuilder.Entity("hienv_asp.Models.ErrorViewModel", b =>
                {
                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ErrorViewModel");
                });

            modelBuilder.Entity("hienv_asp.Models.Layout", b =>
                {
                    b.Property<int>("layout_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("layout_id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("layout_id");

                    b.ToTable("oc_layout");
                });
#pragma warning restore 612, 618
        }
    }
}