using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("645af0af-3598-4175-8507-7358e01e3d68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 31, 103, 42, 49, 61, 87, 208, 156, 164, 154, 64, 67, 96, 105, 29, 77, 229, 110, 58, 6, 228, 138, 209, 3, 194, 214, 164, 133, 101, 108, 137, 196, 190, 170, 43, 120, 74, 92, 58, 76, 223, 75, 41, 52, 63, 177, 27, 225, 228, 27, 149, 203, 9, 135, 113, 195, 61, 62, 135, 57, 50, 86, 150 }, new byte[] { 180, 1, 39, 226, 63, 132, 195, 160, 219, 243, 108, 88, 185, 250, 24, 208, 133, 78, 118, 51, 239, 105, 199, 233, 110, 90, 126, 41, 205, 32, 246, 170, 204, 235, 42, 53, 98, 28, 122, 125, 74, 9, 188, 58, 246, 37, 180, 24, 178, 170, 160, 210, 184, 144, 112, 185, 117, 194, 162, 196, 155, 214, 19, 138, 46, 121, 248, 12, 148, 239, 8, 100, 120, 30, 49, 213, 189, 148, 238, 174, 84, 215, 33, 146, 143, 186, 30, 152, 247, 194, 107, 130, 91, 99, 110, 234, 206, 44, 2, 37, 38, 176, 161, 166, 158, 43, 166, 71, 188, 135, 85, 154, 141, 64, 14, 31, 182, 69, 72, 211, 22, 204, 86, 45, 107, 194, 165, 41 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c7774692-79c5-4922-889d-2d43d6ff5c2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c7774692-79c5-4922-889d-2d43d6ff5c2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 238, 115, 210, 13, 178, 235, 207, 210, 223, 13, 237, 110, 62, 213, 22, 28, 63, 6, 229, 151, 112, 69, 93, 8, 161, 37, 176, 42, 169, 24, 3, 56, 162, 52, 157, 41, 64, 115, 31, 155, 216, 241, 121, 57, 96, 94, 159, 65, 253, 223, 181, 136, 202, 91, 86, 194, 230, 171, 49, 148, 236, 103, 28, 49 }, new byte[] { 48, 14, 184, 59, 8, 23, 188, 91, 255, 20, 30, 239, 250, 6, 178, 212, 158, 14, 15, 162, 101, 195, 235, 206, 143, 100, 133, 116, 116, 128, 56, 170, 250, 152, 61, 95, 244, 188, 203, 243, 106, 173, 3, 138, 31, 127, 238, 124, 191, 132, 216, 121, 214, 18, 208, 98, 143, 20, 159, 38, 5, 223, 43, 197, 23, 84, 66, 44, 219, 159, 51, 54, 153, 189, 42, 202, 90, 234, 121, 223, 74, 137, 220, 210, 232, 219, 160, 47, 109, 21, 131, 189, 116, 212, 198, 62, 97, 74, 158, 134, 168, 180, 106, 139, 72, 219, 39, 224, 47, 143, 18, 126, 244, 10, 112, 137, 212, 216, 251, 19, 41, 75, 243, 72, 184, 31, 63, 176 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("645af0af-3598-4175-8507-7358e01e3d68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d") });
        }
    }
}
