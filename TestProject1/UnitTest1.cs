using MainApplication;
using MainApplication.Entities;
using NUnit.Framework;
using NLog;

namespace TestProject1
{
    public class Tests
    {
        

        Logger logger = LogManager.GetCurrentClassLogger();

        //Kullanýcý Ekleme Testi
        [Test]
        public void Test1()
        {
            
            logger.Log(LogLevel.Info, "Test 1 Baþladý");

            string username = "username";
            string password = "password";

            bool excepted = true;

            bool actual = MainApplication.Form1.RegisterAdmin(new AdminClass(username, password));

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullanýcý Ekleme Testi Baþarýlý");
            }
            else
            {
                logger.Log(LogLevel.Error, "Kullanýcý Ekleme Test Baþarýsýz");
            }

            Assert.AreEqual(excepted, actual);

            
        }


        //Kullanýcý Kontrol testi
        [Test]
        public void Test2()
        {
            logger.Log(LogLevel.Info, "Test 2 Baþladý");

            string username = "username";
            string password = "1234";

            bool excepted = true;

            bool actual = MainApplication.Form1.loginAdmin(new AdminClass(username, password));

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullanýcý Kontrol Testi Baþarýlý");
            }
            else
            {
                logger.Log(LogLevel.Error, "!!!!------Kullanýcý Kontrol Test Baþarýsýz------!!!!");
            }

            Assert.AreEqual(excepted, actual);
            

        }

        [Test]
        public void Test3()
        {
            logger.Log(LogLevel.Info, "Test 3 Baþladý");

            string username = "emre";

            bool excepted = true;

            bool actual = MainApplication.Form1.usernameStartWithNumberValidation(username);

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullanýcý Adý Testi Baþarýlý");
            }
            else
            {
                logger.Log(LogLevel.Error, "Kullanýcý Adý Testi Baþarýsýz");
            }

            Assert.AreEqual(excepted, actual);

            
        }


        public void Test4()
        {

        }
    }
}