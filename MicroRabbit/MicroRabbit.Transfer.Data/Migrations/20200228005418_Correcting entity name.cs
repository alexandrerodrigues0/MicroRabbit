using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class Correctingentityname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrasnferLogs",
                table: "TrasnferLogs");

            migrationBuilder.RenameTable(
                name: "TrasnferLogs",
                newName: "TransferLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs");

            migrationBuilder.RenameTable(
                name: "TransferLogs",
                newName: "TrasnferLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrasnferLogs",
                table: "TrasnferLogs",
                column: "Id");
        }
    }
}
