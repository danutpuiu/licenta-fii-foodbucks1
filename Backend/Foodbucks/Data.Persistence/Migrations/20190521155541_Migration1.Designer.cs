﻿// <auto-generated />
using System;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodbucksWebApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190521155541_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductId");

                    b.Property<double>("Quantity");

                    b.Property<string>("UnitOfMeasurement");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.Instruction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("RecipeId");

                    b.HasKey("Id");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Name");

                    b.Property<double>("Quantity");

                    b.Property<string>("UnitOfMeasurement");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.ProductStore", b =>
                {
                    b.Property<Guid>("ProductId");

                    b.Property<Guid>("StoreId");

                    b.Property<double>("Price");

                    b.HasKey("ProductId", "StoreId");

                    b.ToTable("ProductStores");
                });

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<int>("CookingTime");

                    b.Property<string>("Description");

                    b.Property<int>("Likes");

                    b.Property<string>("Name");

                    b.Property<byte>("Rating");

                    b.Property<int>("Servings");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Data.Domain.Entities.RecipeEntities.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
