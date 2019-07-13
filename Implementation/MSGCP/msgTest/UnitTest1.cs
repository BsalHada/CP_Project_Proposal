using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSGCP;



namespace msgTest
{
    [TestClass]
    public class UnitTest1
    {
        User user = new User();
           
        [TestMethod]
        public void UserLogin()
        {
            string user_Name = "HADA";
            string password = "1212";
            bool expected = true;
            bool result = user.checkLogin(user_Name,password);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void User()
        {
           
            bool expected = true;
            bool result = true;
            Assert.AreEqual(expected, result);
        }
    }
}
