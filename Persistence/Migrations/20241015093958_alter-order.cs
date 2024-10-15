using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class alterorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96e6f3cc-6c8c-4610-86c8-df45e2a0d4ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a029fc42-db58-4b12-b859-95995977a1f6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ab9451d-36a2-4bfb-aee9-b9e8dadbe88e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("340b066a-980f-4947-bf94-6fc90cfdec93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3815aba3-2061-43af-bcba-efcb20d46d5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a03090f-c8bd-422b-bf7a-98a5e37f383e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("427d1b7e-bd22-4d98-87d3-902aed143f5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61065806-5feb-40db-92b8-054e1dd1a990"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b145346f-26c6-4ee7-94c7-528759a6e241"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccfd69d8-2187-4c7e-a94e-67da93d464b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d30f449c-3554-43ae-9c98-c5283d607735"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("5093bfbd-a8c6-4961-aafe-502617085523"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("ae00f1d7-295a-45fe-9c14-7eb3c102329f"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("89fdaf6a-19f1-4e7a-901f-7da90f015527"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("edd8392a-9002-44d6-ad8e-7a135484f2ca"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Dishes",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_OrderId",
                table: "Dishes",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Orders_OrderId",
                table: "Dishes",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Orders_OrderId",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_OrderId",
                table: "Dishes");

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

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Dishes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96e6f3cc-6c8c-4610-86c8-df45e2a0d4ea", null, "8d4ca60e-73bf-4848-b409-86cb87b17852", "Client", "CLIENT" },
                    { "a029fc42-db58-4b12-b859-95995977a1f6", null, "d379f3a6-5cb8-4185-906b-c5171490b3fd", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DishId", "Icon", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1ab9451d-36a2-4bfb-aee9-b9e8dadbe88e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-plant-wilt", false, "Vegan Diet", null, null },
                    { new Guid("340b066a-980f-4947-bf94-6fc90cfdec93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-egg", false, "Ketogenic Diet", null, null },
                    { new Guid("3815aba3-2061-43af-bcba-efcb20d46d5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-umbrella-beach", false, "Mediterranean Diet", null, null },
                    { new Guid("3a03090f-c8bd-422b-bf7a-98a5e37f383e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-mountain", false, "Paleo Diet", null, null },
                    { new Guid("427d1b7e-bd22-4d98-87d3-902aed143f5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-clover", false, "Vegetarian Diet", null, null },
                    { new Guid("61065806-5feb-40db-92b8-054e1dd1a990"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-scale-balanced", false, "Balanced Diet", null, null },
                    { new Guid("b145346f-26c6-4ee7-94c7-528759a6e241"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gluten-free-icon", false, "Low Carb Diet", null, null },
                    { new Guid("ccfd69d8-2187-4c7e-a94e-67da93d464b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-fish", false, "Pescatarian Diet", null, null },
                    { new Guid("d30f449c-3554-43ae-9c98-c5283d607735"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-dna", false, "Dukan Diet", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("5093bfbd-a8c6-4961-aafe-502617085523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Credit Card", null, null },
                    { new Guid("ae00f1d7-295a-45fe-9c14-7eb3c102329f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cash", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingProviders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "Price", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("89fdaf6a-19f1-4e7a-901f-7da90f015527"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uber", 100, null, null },
                    { new Guid("edd8392a-9002-44d6-ad8e-7a135484f2ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marsool", 100, null, null }
                });
        }
    }
}
