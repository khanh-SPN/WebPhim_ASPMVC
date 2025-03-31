using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineAimane.Migrations
{
    public partial class NEW1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "1beea0be-b9a4-4f10-aeb1-8df3cafa6627" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecee7176-9f65-468a-a0e0-544543ccf605");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1beea0be-b9a4-4f10-aeb1-8df3cafa6627");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac23b3bc-2b30-4678-a5e4-3fa4154eed8f", "3e0b82bf-2df9-4280-957b-b6e9fda33364", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bc822e0-2c68-4772-99c8-d1f693484e97", 0, "e2150db3-9de6-4f1d-b983-d4f5f431237f", "adminspn@gmail.com", true, true, null, "ADMINSPN@GMAIL.COM", "ADMINSPN", "AQAAAAEAACcQAAAAEE6APJ4ANkmZ3S9xWTVSvyVjGfyHKwspyAzADJeKoCQswIdC5rQCAAFkFql1vHrNkg==", null, false, "71196d31-db11-46ec-80e5-2ed69f027db7", false, "adminspn" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ac23b3bc-2b30-4678-a5e4-3fa4154eed8f", "6bc822e0-2c68-4772-99c8-d1f693484e97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac23b3bc-2b30-4678-a5e4-3fa4154eed8f", "6bc822e0-2c68-4772-99c8-d1f693484e97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac23b3bc-2b30-4678-a5e4-3fa4154eed8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc822e0-2c68-4772-99c8-d1f693484e97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "f6f16544-b679-48ed-8513-d3d960d9507c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1beea0be-b9a4-4f10-aeb1-8df3cafa6627", 0, "f3e57121-53cc-43fb-b4de-196b93964b2a", "aimanecouissi@gmail.com", true, true, null, "AIMANECOUISSI@GMAIL.COM", "AIMANECOUISSI", "AQAAAAEAACcQAAAAEAKYkGvyrL3xSojbKCgWLskQ18U7vwfdqN87/0iouMCodG1uYPkIyG7ZtNFg337Q0g==", null, false, "14d7aecd-4bca-4688-b2e4-991cee48c967", false, "aimanecouissi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "1beea0be-b9a4-4f10-aeb1-8df3cafa6627" });
        }
    }
}
