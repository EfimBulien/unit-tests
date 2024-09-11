using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordCheck.Tests
{
    [TestClass]
    public class PassCheckTests
    {
        [TestMethod]
        public void Pass_passwordcheck_0return()
        {
            const int expected = 0;
            const string password = "пароль";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pass_passwordcheck_1return()
        {
            const int expected = 1;
            const string password = "password";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pass_passwordcheck_2return()
        {
            const int expected = 2;
            const string password = "password1";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pass_passwordcheck_3return()
        {
            const int expected = 3;
            const string password = "Password1";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pass_passwordcheck_4return()
        {
            const int expected = 4;
            const string password = "Pass|word1";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pass_passwordcheck_5return()
        {
            const int expected = 5;
            const string password = "Pass|word10";
            var passCheck = new PassCheck();
            var actual = passCheck.Pass(password);
            Assert.AreEqual(expected, actual);
        }
    }
}
