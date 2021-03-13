using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDModel
{
	public partial class Character
	{
		// Foreign keys from Character
		public Character()
		{
			Moves = new HashSet<Move>();
		}

		// Primary key
		public int CharacterId { get; set; }

		public string CharacterName { get; set; }
		public string Quote { get; set; }
		public int Health { get; set; }
		public int Stun { get; set; }
		public int ForwardDash { get; set; }
		public int BackDash { get; set; }
		public Uri CharacterPicture { get; set; }

		// Foreign keys from Character
		public virtual ICollection<Move> Moves { get; set; }
	}
}
