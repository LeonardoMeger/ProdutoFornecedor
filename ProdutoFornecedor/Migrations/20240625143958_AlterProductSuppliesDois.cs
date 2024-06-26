using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoFornecedor.Migrations
{
    public partial class AlterProductSuppliesDois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProdutoFornecedor");

            migrationBuilder.DropColumn(
                name: "SupllierId",
                table: "ProdutoFornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupllierId",
                table: "ProdutoFornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
