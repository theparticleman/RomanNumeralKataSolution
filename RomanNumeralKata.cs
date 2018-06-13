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
    }
}