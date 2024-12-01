using Tyuiu.NovikovDS.Sprint6.Task1.V18.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int start = -1, stop = 1;

            int count = 0;
            for (int i = start; i <= stop; i++) count++;

            double[] mass = new double[count];
            mass[0] = -0.35;
            mass[1] = 2;
            mass[2] = 4.35;

            var res = ds.GetMassFunction(start, stop);

            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(mass[i], res[i]);
            }
        }
    }
}