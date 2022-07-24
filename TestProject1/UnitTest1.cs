using MainApplication;
using MainApplication.Entities;
using NUnit.Framework;
using NLog;

namespace TestProject1
{
    public class Tests
    {
        

        Logger logger = LogManager.GetCurrentClassLogger();

        //Kullan�c� Ekleme Testi
        [Test]
        public void Test1()
        {
            
            logger.Log(LogLevel.Info, "Test 1 Ba�lad�");

            string username = "username";
            string password = "password";

            bool excepted = true;

            bool actual = MainApplication.Form1.RegisterAdmin(new AdminClass(username, password));

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullan�c� Ekleme Testi Ba�ar�l�");
            }
            else
            {
                logger.Log(LogLevel.Error, "Kullan�c� Ekleme Test Ba�ar�s�z");
            }

            Assert.AreEqual(excepted, actual);

            
        }


        //Kullan�c� Kontrol testi
        [Test]
        public void Test2()
        {
            logger.Log(LogLevel.Info, "Test 2 Ba�lad�");

            string username = "username";
            string password = "1234";

            bool excepted = true;

            bool actual = MainApplication.Form1.loginAdmin(new AdminClass(username, password));

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullan�c� Kontrol Testi Ba�ar�l�");
            }
            else
            {
                logger.Log(LogLevel.Error, "!!!!------Kullan�c� Kontrol Test Ba�ar�s�z------!!!!");
            }

            Assert.AreEqual(excepted, actual);
            

        }

        [Test]
        public void Test3()
        {
            logger.Log(LogLevel.Info, "Test 3 Ba�lad�");

            string username = "emre";

            bool excepted = true;

            bool actual = MainApplication.Form1.usernameStartWithNumberValidation(username);

            if (excepted == actual)
            {
                logger.Log(LogLevel.Info, "Kullan�c� Ad� Testi Ba�ar�l�");
            }
            else
            {
                logger.Log(LogLevel.Error, "Kullan�c� Ad� Testi Ba�ar�s�z");
            }

            Assert.AreEqual(excepted, actual);

            
        }


        public void Test4()
        {

        }
    }
}