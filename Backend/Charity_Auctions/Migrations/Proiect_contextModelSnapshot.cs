﻿// <auto-generated />
using System;
using Charity_Auctions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Charity_Auctions.Migrations
{
    [DbContext(typeof(Proiect_context))]
    partial class Proiect_contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Charity_Auctions.Entities.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa_livrare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_comanda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Userid");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Comentariu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Com")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_produs")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comentarii");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cos_Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int?>("Cos_CumparaturiId")
                        .HasColumnType("int");

                    b.Property<int>("Cos_cumparaturi_Id")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cos_CumparaturiId");

                    b.HasIndex("ProdusId");

                    b.ToTable("Cos_Produs");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cos_cumparaturi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Cos_cumparaturi");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cosprodus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cosproduse");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Charity_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.Property<int>("Tabel_MarimiId")
                        .HasColumnType("int");

                    b.Property<string>("Url_poza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Tabel_MarimiId")
                        .IsUnique();

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Produs_Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ComandaId", "ProdusId");

                    b.HasIndex("ProdusId");

                    b.ToTable("Produs_Comanda");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Tabel_Marimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("L")
                        .HasColumnType("int");

                    b.Property<int>("M")
                        .HasColumnType("int");

                    b.Property<int>("S")
                        .HasColumnType("int");

                    b.Property<int>("XL")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tabel_Marimi");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cos_cumparaturi_id")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Comanda", b =>
                {
                    b.HasOne("Charity_Auctions.Entities.User", "User")
                        .WithMany("Comenzi")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cos_Produs", b =>
                {
                    b.HasOne("Charity_Auctions.Entities.Cos_cumparaturi", "Cos_Cumparaturi")
                        .WithMany("Cos_produss")
                        .HasForeignKey("Cos_CumparaturiId");

                    b.HasOne("Charity_Auctions.Entities.Produs", "Produs")
                        .WithMany("Cos_produss")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cos_Cumparaturi");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cos_cumparaturi", b =>
                {
                    b.HasOne("Charity_Auctions.Entities.User", "User")
                        .WithOne("cos_Cumparaturi")
                        .HasForeignKey("Charity_Auctions.Entities.Cos_cumparaturi", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Produs", b =>
                {
                    b.HasOne("Charity_Auctions.Entities.Tabel_Marimi", "Tabel_Marimi")
                        .WithOne("Produs")
                        .HasForeignKey("Charity_Auctions.Entities.Produs", "Tabel_MarimiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tabel_Marimi");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Produs_Comanda", b =>
                {
                    b.HasOne("Charity_Auctions.Entities.Comanda", "Comanda")
                        .WithMany("Produs_Comandas")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Charity_Auctions.Entities.Produs", "Produs")
                        .WithMany("Produs_Comandas")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Comanda", b =>
                {
                    b.Navigation("Produs_Comandas");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Cos_cumparaturi", b =>
                {
                    b.Navigation("Cos_produss");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Produs", b =>
                {
                    b.Navigation("Cos_produss");

                    b.Navigation("Produs_Comandas");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.Tabel_Marimi", b =>
                {
                    b.Navigation("Produs");
                });

            modelBuilder.Entity("Charity_Auctions.Entities.User", b =>
                {
                    b.Navigation("Comenzi");

                    b.Navigation("cos_Cumparaturi");
                });
#pragma warning restore 612, 618
        }
    }
}
