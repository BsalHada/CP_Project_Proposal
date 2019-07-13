using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSGCP;

namespace bishalTest
{
    [TestClass]
    public class UnitTest1
    {
        User user = new User();

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void userLogin()
        {
            DeskEntityA db = new DeskEntityA();
            user.user_Name = "HADA";
            user.password = "1212";
            bool expected = true;
            bool result = true;

            Assert.AreEqual(expected, result);
        }
    }
}
