using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Raindrops.UnitTests
{
    [TestClass]
    public class RaindropsTests
    {
        Raindrops rd = new Raindrops();

        [TestMethod]
        public void The_sound_for_1_is_1()
        {
            Assert.AreEqual("1", rd.Convert(1));
        }

        [TestMethod]
        public void The_sound_for_3_is_pling()
        {
            Assert.AreEqual("Pling", rd.Convert(3));
        }

        [TestMethod]
        public void The_sound_for_5_is_plang()
        {
            Assert.AreEqual("Plang", rd.Convert(5));
        }

        [TestMethod]
        public void The_sound_for_7_is_plong()
        {
            Assert.AreEqual("Plong", rd.Convert(7));
        }

        [TestMethod]
        public void The_sound_for_6_is_pling_as_it_has_a_factor_3()
        {
            Assert.AreEqual("Pling", rd.Convert(6));
        }

        [TestMethod]
        public void Number_2_to_the_power_3_does_not_make_a_raindrop_sound_as_3_is_the_exponent_not_the_base()
        {
            Assert.AreEqual("8", rd.Convert(8));
        }

        [TestMethod]
        public void The_sound_for_9_is_pling_as_it_has_a_factor_3()
        {
            Assert.AreEqual("Pling", rd.Convert(9));
        }

        [TestMethod]
        public void The_sound_for_10_is_plang_as_it_has_a_factor_5()
        {
            Assert.AreEqual("Plang", rd.Convert(10));
        }

        [TestMethod]
        public void The_sound_for_14_is_plong_as_it_has_a_factor_of_7()
        {
            Assert.AreEqual("Plong", rd.Convert(14));
        }

        [TestMethod]
        public void The_sound_for_15_is_plingplang_as_it_has_factors_3_and_5()
        {
            Assert.AreEqual("PlingPlang", rd.Convert(15));
        }

        [TestMethod]
        public void The_sound_for_21_is_plingplong_as_it_has_factors_3_and_7()
        {
            Assert.AreEqual("PlingPlong", rd.Convert(21));
        }

        [TestMethod]
        public void The_sound_for_25_is_plang_as_it_has_a_factor_5()
        {
            Assert.AreEqual("Plang", rd.Convert(25));
        }

        [TestMethod]
        public void The_sound_for_27_is_pling_as_it_has_a_factor_3()
        {
            Assert.AreEqual("Pling", rd.Convert(27));
        }

        [TestMethod]
        public void The_sound_for_35_is_plangplong_as_it_has_factors_5_and_7()
        {
            Assert.AreEqual("PlangPlong", rd.Convert(35));
        }

        [TestMethod]
        public void The_sound_for_49_is_plong_as_it_has_a_factor_7()
        {
            Assert.AreEqual("Plong", rd.Convert(49));
        }

        [TestMethod]
        public void The_sound_for_52_is_52()
        {
            Assert.AreEqual("52", rd.Convert(52));
        }

        [TestMethod]
        public void The_sound_for_105_is_plingplangplong_as_it_has_factors_3_5_and_7()
        {
            Assert.AreEqual("PlingPlangPlong", rd.Convert(105));
        }

        [TestMethod]
        public void The_sound_for_3125_is_plang_as_it_has_a_factor_5()
        {
            Assert.AreEqual("Plang", rd.Convert(3125));
        }
    }
}
