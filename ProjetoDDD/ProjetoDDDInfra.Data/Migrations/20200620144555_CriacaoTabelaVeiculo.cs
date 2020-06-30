using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDDDInfra.Data.Migrations
{
    public partial class CriacaoTabelaVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<string>(type: "varchar(500)", nullable: false),
                    Quilometragem = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    AnoModelo = table.Column<int>(type: "int", nullable: false),
                    AnoFabricao = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "varchar(500)", nullable: false),
                    MarcaID = table.Column<int>(nullable: true),
                    ModeloID = table.Column<int>(nullable: true),
                    VersaoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Veiculo_Marca_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marca",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_Modelo_ModeloID",
                        column: x => x.ModeloID,
                        principalTable: "Modelo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_Versao_VersaoID",
                        column: x => x.VersaoID,
                        principalTable: "Versao",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_MarcaID",
                table: "Veiculo",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_ModeloID",
                table: "Veiculo",
                column: "ModeloID");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_VersaoID",
                table: "Veiculo",
                column: "VersaoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
