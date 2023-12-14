using FermatTheorem;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(!Program.CheckFermatTheorem(1, 2, 3, 4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(Program.CheckFermatTheorem(0, 0, 0, 4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(!Program.CheckFermatTheorem(5, 6, 7, 1));
        }
    }
}