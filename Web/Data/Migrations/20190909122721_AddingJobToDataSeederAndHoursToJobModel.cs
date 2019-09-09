using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobWebsite.Data.Migrations
{
    public partial class AddingJobToDataSeederAndHoursToJobModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserTypes",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(5665),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobTypes",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(6707),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.AddColumn<string>(
                name: "Responsibilities",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkingHoursEnd",
                table: "Jobs",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkingHoursStart",
                table: "Jobs",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPosistions",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(5247),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobKeySkills",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(2613),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobCategories",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(585),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobBenefits",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.CreateTable(
                name: "AttachmentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachmentType_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachmentType_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 366, DateTimeKind.Local).AddTicks(8199)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    AttachmentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentType_AttachmentTypeId",
                        column: x => x.AttachmentTypeId,
                        principalTable: "AttachmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachment_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachment_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_AttachmentTypeId",
                table: "Attachment",
                column: "AttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_CreatedById",
                table: "Attachment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UpdatedById",
                table: "Attachment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UserId",
                table: "Attachment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentType_CreatedById",
                table: "AttachmentType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentType_UpdatedById",
                table: "AttachmentType",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "AttachmentType");

            migrationBuilder.DropColumn(
                name: "Responsibilities",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "WorkingHoursEnd",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "WorkingHoursStart",
                table: "Jobs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserTypes",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7824),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobTypes",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(7323),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPosistions",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7342),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobKeySkills",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(5532),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobCategories",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(3596),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 373, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobBenefits",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 9, 13, 27, 21, 372, DateTimeKind.Local).AddTicks(8529));
        }
    }
}
