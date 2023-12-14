using FermatTheorem;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(!Program.CheckFermatTheorem(1, 2, 3, 4));
        }
        [Test]
        public void Test2()
        {
            Assert.IsTrue(Program.CheckFermatTheorem(0, 0, 0, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue(!Program.CheckFermatTheorem(5, 6, 7, 1));
        }
    }
}