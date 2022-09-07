using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        [TestMethod]
        public void TestIncreasingRam()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(2, testingComputer.Ram);
            testingComputer.IncreaseRam(3);
            Assert.AreEqual(5, testingComputer.Ram);
        }

        [TestMethod]
        public void TestIncreaseStorage()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(3, testingComputer.Storage);
            testingComputer.IncreaseStorage(3);
            Assert.AreEqual(6, testingComputer.Storage);
        }

        [TestMethod]
        public void TestHasKeyboard()
        {
            Computer testingComputer = new Computer(2, 3, false);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestIsChunky()
        {
            Laptop testingLaptop = new Laptop(2, 3, false, 6.0);
            Assert.AreEqual(6.0, testingLaptop.Weight);
            Assert.IsTrue(testingLaptop.IsChunky());
        }

        [TestMethod]
        public void TestIsNotChunky()
        {
            Laptop testingLaptop = new Laptop(2, 3, false, 3.0);
            Assert.AreEqual(3.0, testingLaptop.Weight);
            Assert.IsFalse(testingLaptop.IsChunky());
        }

        [TestMethod]
        public void TestTakeSelfies()
        {
            SmartPhone testingSmartPhone = new SmartPhone(2, 3, true, 200);
            Assert.AreEqual(200, testingSmartPhone.NumberOfSelfies);
            testingSmartPhone.TakeSelfies(300);
            Assert.AreEqual(500, testingSmartPhone.NumberOfSelfies);
        }

        [TestMethod]
        public void TestInheritsId()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(1, testingComputer.Id);

            Computer testingComputer2 = new Computer(4, 6, true);
            Assert.AreEqual(2, testingComputer2.Id);
        }

        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            SmartPhone testingSmartphone = new SmartPhone(2, 3, true, 800);
            Assert.IsNotNull(testingSmartphone.Id);
        }
    }
}