using FDModel;
using System.Collections.Generic;
using System.Linq;

namespace FDManager
{
	public class CharacterManager
	{
		public Character SelectedCharacter { get; set; }

		/// <summary>
		/// Creates a new character and saves it to the database.
		/// </summary>
		/// <param name="characterName"></param>
		/// <param name="quote"></param>
		/// <param name="health"></param>
		/// <param name="stun"></param>
		/// <param name="forwardDash"></param>
		/// <param name="backDash"></param>
		/// <param name="characterPicture"></param>
		public void CreateCharacter(string characterName,
			string quote,
			int health,
			int stun,
			int forwardDash,
			int backDash,
			string characterPicture)
		{
			var newCharacter = new Character()
			{
				CharacterName = characterName,
				Quote = quote,
				Health = health,
				Stun = stun,
				ForwardDash = forwardDash,
				BackDash = backDash,
				CharacterPicture = characterPicture
			};

			using (var db = new FrameDataContext())
			{
				db.Characters.Add(newCharacter);
				db.SaveChanges();
			}
		}

		/// <summary>
		/// Retrieves all the Characters in the database
		/// </summary>
		/// <returns>
		/// List of Characters
		/// </returns>
		public List<Character> RetrieveAllCharacters()
		{
			using (var db = new FrameDataContext())
			{
				return db.Characters.ToList();
			}
		}

		/// <summary>
		/// Sets the selected object as the Character
		/// </summary>
		/// <param name="selectedCharacter"></param>
		public void SetSelectedCharacter(object selectedCharacter)
		{
			SelectedCharacter = (Character)selectedCharacter;
		}
	}
}