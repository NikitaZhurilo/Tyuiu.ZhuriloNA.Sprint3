using Tyuiu.ZhuriloNA.Sprint3.Task5.V26.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 2;
            int stopValue1 = 2;
            int stopValue2 = 4;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(56.587, res);
        }
    }
}