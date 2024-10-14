using Tyuiu.ZhuriloNA.Sprint3.Task0.V5.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 3;
            int stopValue = 7;
            double res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(68.173, res);
        }
    }
}