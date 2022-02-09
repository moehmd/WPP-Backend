using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedFormatAndCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Hybrid Work" },
                    { 2, "Hybrid Work Research" },
                    { 3, "Modern Collaboration" },
                    { 4, "Employee Experience" },
                    { 5, "Next Gen Endpoints and Devices" }
                });

            migrationBuilder.InsertData(
                table: "Format",
                columns: new[] { "FormatId", "Name" },
                values: new object[,]
                {
                    { 1, "On-demand Videos" },
                    { 2, "Events and Webinars" },
                    { 3, "Articles and eBooks" },
                    { 4, "Immersion Workshops" },
                    { 5, "Technical Training" },
                    { 6, "End User Training" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 6);
        }
    }
}
