using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        public void ConvertTests(int arabic, string roman)
        {
            Assert.That(ArabicToRoman.Convert(arabic), Is.EqualTo(roman));
        }
    }

    internal class ArabicToRoman
    {
        static List<(int arabic, string roman)> lookup = new List<(int, string)>
        {
            (50, "L"),
            (10, "X"),
            (5, "V"),
            (1, "I")
        };

        internal static string Convert(int arabic)
        {
            if (arabic == 0) return "";
            var conversion = lookup.First(x => x.arabic <= arabic);
            return conversion.roman + Convert(arabic - conversion.arabic);
        }
    }
}