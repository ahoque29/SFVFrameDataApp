using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDModel
{
	public partial class Character
	{
		public override string ToString()
		{
			return CharacterName;
		}
	}

	public partial class Move
	{
		public override string ToString()
		{
			return MoveName;
		}
	}
}
