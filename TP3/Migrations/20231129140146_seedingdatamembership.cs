using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3.Migrations
{
    public partial class seedingdatamembership : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "memebrshiptypes",
                columns: new[] { "id", "DiscountRate", "DurationMonth", "SignUpFee" },
                values: new object[] { 1, 0f, 1, 50f });

            migrationBuilder.InsertData(
                table: "memebrshiptypes",
                columns: new[] { "id", "DiscountRate", "DurationMonth", "SignUpFee" },
                values: new object[] { 2, 5f, 3, 100f });

            migrationBuilder.InsertData(
                table: "memebrshiptypes",
                columns: new[] { "id", "DiscountRate", "DurationMonth", "SignUpFee" },
                values: new object[] { 3, 10f, 6, 150f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "memebrshiptypes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "memebrshiptypes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "memebrshiptypes",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
