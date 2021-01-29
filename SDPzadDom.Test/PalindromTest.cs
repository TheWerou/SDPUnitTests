using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SDPzadDom;

namespace SDPzadDom.Test
{
    [TestFixture]
    class PalindromTest
    {
        Palindrom palindromObject;

        [SetUp]
        public void Setup()
        {
            this.palindromObject = new Palindrom();
        }

        [TestCase("adosiłypyłisoda")]
        [TestCase("atokiwizdziwikota")]
        [TestCase("ikarjadajraki")]
        public void AnalizeTextTestCleanTrue(string value)
        {
            Assert.IsTrue(palindromObject.AnalizeText(value));
        }

        [TestCase("alamakota")]
        [TestCase("komuwdrogetemu")]
        [TestCase("jakistest")]
        [TestCase("ikarjadajrak")]
        [TestCase("adosłypyłisoda")]
        public void AnalizeTextTestCleanFalse(string value)
        {
            Assert.IsFalse(palindromObject.AnalizeText(value));
        }

        [TestCase("")]
        [TestCase("  ")]
        [TestCase("     ")]
        [TestCase("\r")]
        [TestCase("\t")]
        [TestCase("\nhehe")]
        [TestCase("alama\nkota")]
        [TestCase("komuwdroge\ntemu")]
        [TestCase("jaki\nstest")]
        [TestCase("i\tkarjadajrak")]
        [TestCase("ad\nosłypyłi\nsoda")]
        [TestCase("ikarjadajrak")]
        [TestCase("ad\rosłypyłi\rsoda")]
        public void AnalizeTextTestCleanWhiteSpacesFalse(string value)
        {
            Assert.IsFalse(palindromObject.AnalizeText(value));
        }


        [TestCase("a do s\niły pył i soda")]
        [TestCase("a t\no kiwi zdz\riwi ko\tta")]
        [TestCase("ik\nar jadaj ra\rki")]
        [TestCase("a dosiły pył i     soda")]
        [TestCase("a to \tkiwi zdziwikota           ")]
        [TestCase("i\tka  rjad\najraki       ")]
        public void AnalizeTextTestCleanWhiteSpacesTrue(string value)
        {
            Assert.IsTrue(palindromObject.AnalizeText(value));
        }

        [TestCase("a do siły pył i soda")]
        [TestCase("a to kiwi zdziwi kota")]
        [TestCase("ikar jadaj raki")]
        [TestCase("a dosiły pył i     soda")]
        [TestCase("a to kiwi zdziwikota           ")]
        [TestCase("ika  rjadajraki       ")]
        public void AnalizeTextTestSpaceTrue(string value)
        {
            Assert.IsTrue(palindromObject.AnalizeText(value));
        }

        [TestCase("A do siły pył i soda")]
        [TestCase("a to kiwi zdziwi kota")]
        [TestCase("ikar jAdaj raki")]
        [TestCase("A dosiły pył i     soda")]
        [TestCase("a to Kiwi zdziwIkota           ")]
        [TestCase("ika  rjadAjrakI       ")]
        public void AnalizeTextTestSpaceBigLeterTrue(string value)
        {
            Assert.IsTrue(palindromObject.AnalizeText(value));
        }

        [TestCase("A do siły pył i soda.")]
        [TestCase("a to kiwi zdziwi kota.")]
        [TestCase("ikar jAd..aj raki")]
        [TestCase("A .dosiły pył i.     soda")]
        [TestCase("a to Kiw.i zdziwI.kota           ")]
        [TestCase("ika . rjadAj.rakI       ")]
        public void AnalizeTextTestSpaceBigLeterDotTrue(string value)
        {
            Assert.IsTrue(palindromObject.AnalizeText(value));
        }

        [TestCase("A do siły py i soda.")]
        [TestCase("a to kii zdziwi kota.")]
        [TestCase("ikar d..aj raki")]
        [TestCase("A .dosiy pył .     soda")]
        [TestCase("a to Ki.i zdziwI.kota           ")]
        [TestCase("ika . raAj.rakI       ")]
        public void AnalizeTextTestSpaceBigLeterDotFalse(string value)
        {
            Assert.IsFalse(palindromObject.AnalizeText(value));
        }

    }
}
