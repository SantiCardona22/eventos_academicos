using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventosAcademicos.API.Migrations
{
    /// <inheritdoc />
    public partial class MyFirtMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvenAcademicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEvento = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    FechaInicio = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    FechaFinalizacion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvenAcademicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    AfiliacionInstitucional = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    AreaInteres = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    TipoParticipacion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramaEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horarios = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Sesiones = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Ponentes = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    TemasSesion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramaEvento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvenAcademicos");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "ProgramaEvento");
        }
    }
}
