using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSGCP;
using System;
using System.Security.Cryptography;
using System.Text;

namespace bishal
{

    [TestClass]
    public class UnitTest1
    {
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);

            }
        }

        User user = new User();
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        Remark rmk = new Remark();
        Section sec = new Section();
        SubjectMarks sbm = new SubjectMarks();

        [TestMethod]
        public void UserLogin()
        {
            string user_Name = "Ram";
            string password = "ram121";
            bool expected = true;
            bool result = user.checkLogin(user_Name,password);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UserReg()
        {
           user.user_Name = "Rama".Trim();
           user.password = Encrypt("ram12");
           db.User.Add(user);
           int result=db.SaveChanges();
           int expected = 1;
           Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddSub()
        {
            sub.subject1= "Occupation".Trim();
            db.Subject.Add(sub);
            int result = db.SaveChanges();
            int expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddRemark()
        {
            rmk.remark1 = "VeryGood,Do your best!".Trim();
            db.Remark.Add(rmk);
            int result = db.SaveChanges();
            int expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddSection()
        {
            sec.section1 = "F".Trim();
            db.Section.Add(sec);
            int result = db.SaveChanges();
            int expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddFullPassMarks()
        {
            sbm.subject= "Ocupation".Trim();
            sbm.passmarks = 50;
            sbm.fullmarks = 100;
            db.SubjectMarks.Add(sbm);
            int result = db.SaveChanges();
            int expected = 0;
            Assert.AreEqual(expected, result);
        }


    }
}
