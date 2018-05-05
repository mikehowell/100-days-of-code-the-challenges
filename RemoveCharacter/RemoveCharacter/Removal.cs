using System.Collections.Generic;
using System.Linq;

namespace RemoveCharacter
{
    public class Removal
    {
        public string RemoveCharacterFromString(char characterToRemove, string stringLiteral)
        {
            List<string> updatedList = new List<string>();
            char[] current = stringLiteral.ToArray();

            foreach (var character in current)
            {
                if (!character.Equals(characterToRemove))
                    updatedList.Add(character.ToString());
            }

            var updated = string.Empty;
            foreach (var letter in updatedList)
            {
                updated += letter;
            }

            return updated;
        }
    }
}
