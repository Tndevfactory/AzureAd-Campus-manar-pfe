using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tracerapi.Migrations
{
    public partial class createCtrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TracerModels");

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumContratMaintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypePrestation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AskToClose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priorite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateIncident = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEcheance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateProchaineEcheance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateContrat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeContrat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratMaintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAppel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateIntervention = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEcheance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateProchaineEcheance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateContrat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeContrat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratMaintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAppel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTache = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Taches");

            migrationBuilder.CreateTable(
                name: "TracerModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TracerModels", x => x.Id);
                });
        }
    }
}
