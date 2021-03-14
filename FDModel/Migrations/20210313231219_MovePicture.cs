using Microsoft.EntityFrameworkCore.Migrations;

namespace FDModel.Migrations
{
	public partial class MovePicture : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "CharacterPicture",
				table: "Moves",
				newName: "MovePicture");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "MovePicture",
				table: "Moves",
				newName: "CharacterPicture");
		}
	}
}