using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoFornecedor.Migrations
{
    public partial class IdSupplierProdFornecedorDois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoFornecedor_Produtos_ProdutoId",
                table: "ProdutoFornecedor");

            migrationBuilder.DropColumn(
                name: "idFornecedor",
                table: "ProdutoFornecedor");

            migrationBuilder.DropColumn(
                name: "idProduto",
                table: "ProdutoFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoFornecedor_Produtos_ProdutoId",
                table: "ProdutoFornecedor",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoFornecedor_Produtos_ProdutoId",
                table: "ProdutoFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idFornecedor",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idProduto",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoFornecedor_Produtos_ProdutoId",
                table: "ProdutoFornecedor",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id");
        }
    }
}
