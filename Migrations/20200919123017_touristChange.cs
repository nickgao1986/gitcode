using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XieChengAPI.Migrations
{
    public partial class touristChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Rating", "Title", "UpdateTime" },
                values: new object[] { new Guid("be952874-339a-49cf-a044-90ed5c720e4f"), new DateTime(2020, 9, 19, 12, 30, 16, 929, DateTimeKind.Utc).AddTicks(7037), null, "shuoming", null, null, null, null, 0m, null, "ceshititle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("be952874-339a-49cf-a044-90ed5c720e4f"));
        }
    }
}
