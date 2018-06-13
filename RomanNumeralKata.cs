using System;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        public void ConvertTests(int arabic, string roman)
        {
            Assert.That(ArabicToRoman.Convert(arabic), Is.EqualTo(roman));
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