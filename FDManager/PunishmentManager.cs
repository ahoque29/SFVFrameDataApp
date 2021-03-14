using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDModel;

namespace FDManager
{
	public class PunishmentManager
	{
		MoveManager _moveManager = new MoveManager();

		public string SafeOnBlockPicture { get; set; }

		public List<Move> ListOfMovesThatCanPunishOnBlock(int yourCharacterId, int opponentMoveOnBlock)
		{
			var yourMoves = _moveManager.RetrieveACharactersMoveList(yourCharacterId);
			var movesThatCanPunishOnBlock = yourMoves.Where(y => y.StartUp <= -opponentMoveOnBlock).ToList();

			if (!movesThatCanPunishOnBlock.Any())
			{
				SafeOnBlockPicture = @"C:\Users\gaffi\source\repos\SFVFrameDataApp\FDModel\Pictures\MovePictures\safeonblock.png";
			}

			return movesThatCanPunishOnBlock;
		}
	}
}
