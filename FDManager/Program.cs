using System;
using FDModel;
using System.Collections.Generic;
using System.Linq;

namespace FDManager
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//var _characterManager = new CharacterManager();
			//var _moveManager = new MoveManager();

			//// Adding Ryu
			//_characterManager.CreateCharacter("Ryu",
			//	"This is the path of my destiny!",
			//	1025,
			//	1050,
			//	16,
			//	21,
			//	"FDModel/Pictures/CharacterPictures/Ryu.png");

			//// modifying ryu picture
			//using var db = new FrameDataContext();
			//var character = db.Characters.Where(c => c.CharacterId == 1).FirstOrDefault();
			//character.CharacterPicture = @"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\CharacterPictures\Ryu.png";

			//db.SaveChanges();

			// Adding s.LP
			//_moveManager.CreateMove(1,
			//	"s.LP",
			//	3,
			//	2,
			//	7,
			//	2,
			//	4,
			//	30,
			//	70,
			//	"C:/Users/gaffi/source/repos/SFVFrameDataApp/FDModel/Pictures/MovePictures/Ryu_sLP.png");

			//// Adding c.HP
			//_moveManager.CreateMove(1, "c.HP", 6, 4, 24, -10, -7, 90, 150, "C:/Users/gaffi/source/repos/SFVFrameDataApp/FDModel/Pictures/MovePicture/Ryu_cHP.png");

			////modifying c.hp picture
			//using (var db = new FrameDataContext())
			//{
			//	var move = db.Moves.Where(m => m.MoveId == 2).FirstOrDefault();
			//	move.MovePicture = @"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\MovePictures\Ryu_cHP.png";

			//	db.SaveChanges();
			//}

			//// Adding Ken
			//_characterManager.CreateCharacter("Ken",
			//	"Come on! Let's turn up the heat!",
			//	1025, 1050, 15, 24,
			//	@"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\CharacterPictures\Ken.png");

			//// adding s.LK
			//_moveManager.CreateMove(2, "s.LK", 4, 2, 9, -1, 3, 30, 70, @"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\MovePictures\Ken_sLK.png");

			//// adding c.HK
			//_moveManager.CreateMove(2, "c.HK", 8, 3, 23, -12, 73, 90, 150, @"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\MovePictures\Ken_cHK.png");

		}
	}
}