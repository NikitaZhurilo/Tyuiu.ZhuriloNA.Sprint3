using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZhuriloNA.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    res += (i / (Math.Cos(i) + Math.Sin(i)));
                }
            }
            return Math.Round(res, 3);
                    
            
        }
    }
}
