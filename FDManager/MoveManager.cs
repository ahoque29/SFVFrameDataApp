using FDModel;
using System.Collections.Generic;
using System.Linq;


namespace FDManager
{
	public class MoveManager
	{
		/// <summary>
		/// Creates a new move and saves it to the database
		/// </summary>
		/// <param name="characterId"></param>
		/// <param name="startUp"></param>
		/// <param name="active"></param>
		/// <param name="recovery"></param>
		/// <param name="onBlock"></param>
		/// <param name="onHit"></param>
		/// <param name="damage"></param>
		/// <param name="stun"></param>
		/// <param name="movePicture"></param>
		public void CreateMove(int characterId,
			string moveName,
			int startUp,
			int active,
			int recovery,
			int onBlock,
			int onHit,
			int damage,
			int stun,
			string movePicture)
		{
			var newMove = new Move()
			{				
				CharacterId = characterId,
				MoveName = moveName,
				StartUp = startUp,
				Active = active,
				Recovery = recovery,
				OnBlock = onBlock,
				OnHit = onHit,
				Damage = damage,
				Stun = stun,
				MovePicture = movePicture,
			};

			using var db = new FrameDataContext();
			db.Add(newMove);
			db.SaveChanges();
		}

		/// <summary>
		/// Retrieves a Character's Move List
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public List<Move> RetrieveACharactersMoveList(int characterId)
		{
			using var db = new FrameDataContext();

			var moveList = db.Moves.Where(m => m.CharacterId == characterId).ToList();

			return moveList;
		}
	}
}