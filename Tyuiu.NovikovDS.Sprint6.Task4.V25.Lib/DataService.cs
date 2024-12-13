using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NovikovDS.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                mass[k] = Math.Round(Math.Cos(i) + ((4 * i) / 2) - Math.Sin(i) * 3 * i, 2);
                k++;
            }
            return mass;
        }
    }
}
