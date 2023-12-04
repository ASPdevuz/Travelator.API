using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Travelator.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 16, 36, 8, 494, DateTimeKind.Local).AddTicks(6221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 17, 27, 59, 137, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Humans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Davrli reyslar" },
                    { 2, "Tarif reyslar" },
                    { 3, "Xalqaro reyslar" },
                    { 4, "Transiti reyslar" },
                    { 5, "Chaqqon reyslar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Humans_CategoryId",
                table: "Humans",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Humans_Category_CategoryId",
                table: "Humans",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Humans_Category_CategoryId",
                table: "Humans");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Humans_CategoryId",
                table: "Humans");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Humans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 17, 27, 59, 137, DateTimeKind.Local).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 16, 36, 8, 494, DateTimeKind.Local).AddTicks(6221));
        }
    }
}
