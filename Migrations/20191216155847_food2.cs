using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldRecipes.Migrations
{
    public partial class food2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Recipes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_FoodId",
                table: "Recipes",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Foods_FoodId",
                table: "Recipes",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Foods_FoodId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_FoodId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Recipes");
        }
    }
}
