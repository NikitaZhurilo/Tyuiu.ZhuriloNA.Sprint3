using Tyuiu.ZhuriloNA.Sprint3.Task3.V23.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Assert.AreEqual("fd88t 8iu v8r8", res);
        }
    }
}