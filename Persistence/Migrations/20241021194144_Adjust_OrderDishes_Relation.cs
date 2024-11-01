using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Adjust_OrderDishes_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Dishes");

            migrationBuilder.CreateTable(
                name: "DishOrder",
                columns: table => new
                {
                    DishesId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrdersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrder", x => new { x.DishesId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_DishOrder_Dishes_DishesId",
                        column: x => x.DishesId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c2a2769-de49-4e00-b487-baa0c8e09cfa", null, "f1e4be3c-445a-4fee-a06c-b262ebb8666d", "Client", "CLIENT" },
                    { "c920e9a4-f3e1-4f2c-ad8a-e2b297497dbd", null, "d7f4622b-2f3a-4035-8a9d-bcd939dc69ce", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DishId", "Icon", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-umbrella-beach", false, "Mediterranean Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-scale-balanced", false, "Balanced Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gluten-free-icon", false, "Low Carb Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-clover", false, "Vegetarian Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-egg", false, "Ketogenic Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-plant-wilt", false, "Vegan Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-mountain", false, "Paleo Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-fish", false, "Pescatarian Diet", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fa-solid fa-dna", false, "Dukan Diet", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Credit Card", null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cash", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingProviders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "Price", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marsool", 100, null, null },
                    { new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uber", 100, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishOrder_OrdersId",
                table: "DishOrder",
                column: "OrdersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishOrder");

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
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d19"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d20"));

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d21"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d22"));

            migrationBuilder.DeleteData(
                table: "ShippingProviders",
                keyColumn: "Id",
                keyValue: new Guid("c920e9a4-f3e1-4f2c-ad8a-e2b297497d23"));

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
    }
}
