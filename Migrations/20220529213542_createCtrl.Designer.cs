﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tracerapi.Data;

#nullable disable

namespace tracerapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220529213542_createCtrl")]
    partial class createCtrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("tracerapi.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AskToClose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateIncident")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumContratMaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priorite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sujet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePrestation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("tracerapi.Models.Intervention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodeContrat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContratMaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateAppel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateContrat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateEcheance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateIntervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateProchaineEcheance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sujet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("tracerapi.Models.Tache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodeContrat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContratMaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateAppel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateContrat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateEcheance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateProchaineEcheance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateTache")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sujet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Taches");
                });
#pragma warning restore 612, 618
        }
    }
}