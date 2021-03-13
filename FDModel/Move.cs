using System;

namespace FDModel
{
	public partial class Move
	{
		// Primary key
		public int MoveId { get; set; }

		// Foreign key
		public int CharacterId { get; set; }

		public string MoveName { get; set; }
		public int StartUp { get; set; }
		public int Active { get; set; }
		public int Recovery { get; set; }
		public int OnBlock { get; set; }
		public int OnHit { get; set; }
		public int Damage { get; set; }
		public int Stun { get; set; }
		public string CharacterPicture { get; set; }

		// Foreign key
		public virtual Character Character { get; set; }
	}
}