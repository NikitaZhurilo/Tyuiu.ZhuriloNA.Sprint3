using Tyuiu.ZhuriloNA.Sprint3.Task2.V26.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 2;
            int stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(90678524.616, res);
        }
    }
}