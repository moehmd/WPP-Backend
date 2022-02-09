using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedAddItemData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "Description", "FormatId", "Image", "Link", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Learn about the lasting impact of remote work on collaboration work patterns.", 1, "", "", "The effects of remote work on collaboration among information workers" },
                    { 2, 2, "Sign up for Teams Connect to collaborate seamlessly in the same digital environment with anyone, wether inside or outside your organization.", 2, "", "", "Sign up for Microsoft Teams Connect" },
                    { 3, 3, "Learn how Microsoft is partnering with leading brands and retailers from across the globe on their hybrid work journeys.", 3, "", "", "Empowering Hybrid Work for Brands & Retailers" },
                    { 4, 4, "Learn how you can use collaborative apps to simplify and streamline business processes.", 4, "", "", "Digitizing hybrid Work processes" },
                    { 5, 5, "Learn more about Windows 365, see a product demo, and discover the opportunities that Cloud OC presents in the hybrid workplace.", 5, "", "", "Hybrid Windows for a Hybrid World" },
                    { 6, 1, "Explore the key principles behind Microsoft's approach to modern endpoints and the learn why endpoint management and compliance is essential to your Zero Trust security journey.", 6, "", "", "Modernizing Endpoints in the Digital Estate" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6);
        }
    }
}
