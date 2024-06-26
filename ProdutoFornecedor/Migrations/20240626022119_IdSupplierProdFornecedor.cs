using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoFornecedor.Migrations
{
    public partial class IdSupplierProdFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoFornecedor_Fornecedores_FornecedorId",
                table: "ProdutoFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_ProdutoFornecedor_Fornecedores_FornecedorId",
                table: "ProdutoFornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoFornecedor_Fornecedores_FornecedorId",
                table: "ProdutoFornecedor");

            migrationBuilder.DropColumn(
                name: "idFornecedor",
                table: "ProdutoFornecedor");

            migrationBuilder.DropColumn(
                name: "idProduto",
                table: "ProdutoFornecedor");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoFornecedor_Fornecedores_FornecedorId",
                table: "ProdutoFornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id");
        }
    }
}
