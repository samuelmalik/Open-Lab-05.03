using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_05._03
{
    [TestFixture]
    public class Tests
    {

        private Numbers numbers;

        private const int RandSeed = 503503503;
        private const int RandTestCasesCount = 97;

        [OneTimeSetUp]
        public void Init() => numbers = new Numbers();

        [TestCase(1000, "1,000")]
        [TestCase(100000, "100,000")]
        [TestCase(20, "20")]
        [TestCaseSource(nameof(GetRandom))]
        public void FormatNumTest(int num, string expected) =>
            Assert.That(numbers.FormatNum(num), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var num = rand.Next();
                yield return new TestCaseData(num, num.ToString("N0"));
            }
        }

    }
}
