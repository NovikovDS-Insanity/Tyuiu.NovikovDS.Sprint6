using Tyuiu.NovikovDS.Sprint6.Task3.V18.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };

            matrix = ds.Calculate(matrix);

            int[,] res = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 0, 11, 0 }, { 13, 14, 15 } };

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Assert.AreEqual(matrix[i, j], res[i, j]);
                }
            }
        }
    }
}