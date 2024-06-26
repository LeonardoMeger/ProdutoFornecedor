using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoFornecedor.Migrations
{
    public partial class IdSupplierRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_SupplierId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_SupplierId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_SupplierId",
                table: "Produtos",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_SupplierId",
                table: "Produtos",
                column: "SupplierId",
                principalTable: "Fornecedores",
                principalColumn: "Id");
        }
    }
}
