using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldRecipes.Migrations
{
    public partial class food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Recipes_RecipeId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_RecipeId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Foods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_RecipeId",
                table: "Foods",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Recipes_RecipeId",
                table: "Foods",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
