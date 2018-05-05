using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveCharacter.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void RemoveCharacterFromString_Success()
        {
            var sentence = "Hello World";
            var character = 'l';

            var remove = new Removal();
            var expected = "Heo Word";

            Assert.AreEqual(expected, remove.RemoveCharacterFromString(character, sentence));
        }
    }
}
