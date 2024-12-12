using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NovikovDS.Sprint6.Task3.V18.Lib
{
    public class DataService : ISprint6Task3V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 3; i <= 3; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) matrix[i, j] = 0;
                }
            }
            return matrix;
        }
    }
}
