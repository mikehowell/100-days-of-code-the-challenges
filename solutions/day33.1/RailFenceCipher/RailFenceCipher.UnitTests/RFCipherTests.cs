using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RailFenceCipher.UnitTests
{
    [TestClass]
    public class RFCipherTests
    {
        [TestMethod]
        public void Encode_WeAreDiscoveredFleeAtOnce_RailSizeOf3_Returns_WrivdetceAeDsoeeleAnecrFO()
        {
            var rfc = new RFCipher();
            Assert.AreEqual("WrivdetceAeDsoee leA ne  crF O", rfc.Encode("We Are Discovered Flee At Once", 3));
        }

        [TestMethod]
        public void Encode_WeAreDiscoveredFleeAtOnce_RailSizeOf4_Returns_WvFteeDoelAericrdeOcAseen()
        {
            var rfc = new RFCipher();
            Assert.AreEqual("W vFteeDoe lA e ricrde OcAseen", rfc.Encode("We Are Discovered Flee At Once", 4));
        }
        
        [TestMethod]
        public void Decode_WrivdetceAeDsoeeleAnecrFO_RailSizeOf3_Returns_WeAreDiscoveredFleeAtOnce()
        {
            var rfc = new RFCipher();
            Assert.AreEqual("We Are Discovered Flee At Once", rfc.Decode("WrivdetceAeDsoee leA ne  crF O", 3));
        }

        [TestMethod]
        public void Decode_WrivdetceAeDsoeeleAnecrFO_RailSizeOf4_Returns_WeAreDiscoveredFleeAtOnce()
        {
            var rfc = new RFCipher();
            Assert.AreEqual("We Are Discovered Flee At Once", rfc.Decode("W vFteeDoe lA e ricrde OcAseen", 4));
        }
    }
}
