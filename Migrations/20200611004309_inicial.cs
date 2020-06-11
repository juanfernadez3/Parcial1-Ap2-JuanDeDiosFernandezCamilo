using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1_Ap2_JuanDeDiosFernandezCamilo.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArtiuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: false),
                    Inventario = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    ExistenciaInventario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArtiuloId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");
        }
    }
}
