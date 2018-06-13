using System;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ZeroReturnsEmptyString()
        {
            Assert.That(ArabicToRoman.Convert(0), Is.EqualTo(""));
        }

        [Test]
        public void OneReturnsI()
        {
            Assert.That(ArabicToRoman.Convert(1), Is.EqualTo("I"));
        }

        [Test]
        public void FiveReturnsV()
        {
            Assert.That(ArabicToRoman.Convert(5), Is.EqualTo("V"));
        }
    }

    internal class ArabicToRoman
    {
        internal static string Convert(int arabic)
        {
            if (arabic == 0) return "";
            if (arabic == 1) return "I";
            return "V";
        }
    }
}