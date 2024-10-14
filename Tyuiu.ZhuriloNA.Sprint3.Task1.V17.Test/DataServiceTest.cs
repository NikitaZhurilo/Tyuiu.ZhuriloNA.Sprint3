using Tyuiu.ZhuriloNA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 0;
            int startValue = 0;
            int stopValue = 0;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(, res);
        }
    }
}