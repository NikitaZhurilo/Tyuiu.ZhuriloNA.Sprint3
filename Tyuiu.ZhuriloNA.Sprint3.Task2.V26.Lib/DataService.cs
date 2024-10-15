using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZhuriloNA.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            int i = startValue;
            do
            {
                result *= (Math.Pow(value, 3) * startValue) + 2;
                i++;
            } while (i <= stopValue);
            return Math.Round(result, 3);
        }
    }
}
