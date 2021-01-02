using NUnit.Framework;

namespace WarQuest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            WarQuest.WinFormMVC.Models.PlayerOneGame test = new WinFormMVC.Models.PlayerOneGame();
            test.MoneyInitialAmount = 55;
            Assert.AreEqual(test.MoneyInitialAmount, 55);
        }
    }
}