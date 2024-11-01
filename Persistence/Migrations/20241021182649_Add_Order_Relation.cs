using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Add_Order_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c2a2769-de49-4e00-b487-baa0c8e09cfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c920e9a4-f3e1-4f2c-ad8a-e2b297497dbd");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("089a7787-1468-401a-9d6a-e4743139e988"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3dd17f3e-ecff-4840-a26d-50dbe9cf7f0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a5eb93f-46ca-4129-afd4-1dbf5c4d4d8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52bef303-344e-4492-b061-f4ff075d2cb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("594412fd-fbdf-498a-b8d2-d4353c67f185"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f7d3add-5c4e-400d-91b2-f96f8cbda6bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a16e724-1b79-42c7-a62b-8ac61b049f9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db4825c2-518f-4193-ace4-c5b0bc9cc744"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb89310d-3d27-49b4-94bb-6c6db118b1a3"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("24b77ea2-0284-4ffc-b245-11f058ca9bb0"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("263e8939-1488-4d42-9287-051d4fe7c1bf"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("3965629d-c11d-431b-b31b-4346c3ee6335"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("6c7e9fd4-d0f9-4bd0-81ab-6fd894062e2c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41196c2e-663b-4059-827f-be14ec9b952c", null, "37508076-181f-4819-b6ab-e442b07c10b3", "Client", "CLIENT" },
                    { "5f179201-e609-4791-8327-774ab354548b", null, "639445bd-5c3f-4fea-a093-48bdc0f524a2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DishId", "Icon", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2131c723-4378-4b65-b4c5-d18e578d0d38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-mountain", false, "Paleo Diet", null, null },
                    { new Guid("49dad170-6d90-4122-b7a5-5f2f8b21cc4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-clover", false, "Vegetarian Diet", null, null },
                    { new Guid("531ec4f3-e651-41b8-86f7-3d38183d8b45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-plant-wilt", false, "Vegan Diet", null, null },
                    { new Guid("71db9f19-589b-417b-aab7-cade83c653b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-scale-balanced", false, "Balanced Diet", null, null },
                    { new Guid("bc492ba8-1fea-4945-96c5-5e8cd4415591"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-egg", false, "Ketogenic Diet", null, null },
                    { new Guid("e6b30217-da7f-4146-84e1-45144fbd8651"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-fish", false, "Pescatarian Diet", null, null },
                    { new Guid("ecc2f6ac-a216-46e3-b410-8e4ac05a6837"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gluten-free-icon", false, "Low Carb Diet", null, null },
                    { new Guid("f73931d5-2430-40de-b6b9-900dc9d7ffb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-umbrella-beach", false, "Mediterranean Diet", null, null },
                    { new Guid("fa5e8ade-bd6d-41ab-afbd-87898673583a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-dna", false, "Dukan Diet", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("927ea944-3d1d-4f05-a1ee-4f5b430077b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Credit Card", null, null },
                    { new Guid("aac5b336-5f68-437d-8fb4-5ea5a4078560"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cash", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingProviders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "Price", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b93133f-2539-4915-a4e3-702101604a4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marsool", 100, null, null },
                    { new Guid("44f26f52-9deb-4494-a800-e74fd517860e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uber", 100, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41196c2e-663b-4059-827f-be14ec9b952c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f179201-e609-4791-8327-774ab354548b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2131c723-4378-4b65-b4c5-d18e578d0d38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49dad170-6d90-4122-b7a5-5f2f8b21cc4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("531ec4f3-e651-41b8-86f7-3d38183d8b45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71db9f19-589b-417b-aab7-cade83c653b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc492ba8-1fea-4945-96c5-5e8cd4415591"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6b30217-da7f-4146-84e1-45144fbd8651"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecc2f6ac-a216-46e3-b410-8e4ac05a6837"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f73931d5-2430-40de-b6b9-900dc9d7ffb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa5e8ade-bd6d-41ab-afbd-87898673583a"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("927ea944-3d1d-4f05-a1ee-4f5b430077b8"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("aac5b336-5f68-437d-8fb4-5ea5a4078560"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("0b93133f-2539-4915-a4e3-702101604a4c"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("44f26f52-9deb-4494-a800-e74fd517860e"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c2a2769-de49-4e00-b487-baa0c8e09cfa", null, "2997bf06-2349-4556-8670-27e441196ac5", "Client", "CLIENT" },
                    { "c920e9a4-f3e1-4f2c-ad8a-e2b297497dbd", null, "fd6e2909-8aad-4f0a-93e9-c846db9a633c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DishId", "Icon", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("089a7787-1468-401a-9d6a-e4743139e988"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-clover", false, "Vegetarian Diet", null, null },
                    { new Guid("3dd17f3e-ecff-4840-a26d-50dbe9cf7f0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-umbrella-beach", false, "Mediterranean Diet", null, null },
                    { new Guid("4a5eb93f-46ca-4129-afd4-1dbf5c4d4d8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-plant-wilt", false, "Vegan Diet", null, null },
                    { new Guid("52bef303-344e-4492-b061-f4ff075d2cb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-egg", false, "Ketogenic Diet", null, null },
                    { new Guid("594412fd-fbdf-498a-b8d2-d4353c67f185"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-fish", false, "Pescatarian Diet", null, null },
                    { new Guid("5f7d3add-5c4e-400d-91b2-f96f8cbda6bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-dna", false, "Dukan Diet", null, null },
                    { new Guid("9a16e724-1b79-42c7-a62b-8ac61b049f9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-mountain", false, "Paleo Diet", null, null },
                    { new Guid("db4825c2-518f-4193-ace4-c5b0bc9cc744"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-scale-balanced", false, "Balanced Diet", null, null },
                    { new Guid("eb89310d-3d27-49b4-94bb-6c6db118b1a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gluten-free-icon", false, "Low Carb Diet", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("24b77ea2-0284-4ffc-b245-11f058ca9bb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cash", null, null },
                    { new Guid("263e8939-1488-4d42-9287-051d4fe7c1bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Credit Card", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingProviders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "Price", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3965629d-c11d-431b-b31b-4346c3ee6335"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marsool", 100, null, null },
                    { new Guid("6c7e9fd4-d0f9-4bd0-81ab-6fd894062e2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uber", 100, null, null }
                });
        }
    }
}
