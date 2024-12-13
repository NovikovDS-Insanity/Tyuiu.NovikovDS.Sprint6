using Tyuiu.NovikovDS.Sprint6.Task5.V23.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task5.V23.Test
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
            mass[0] = -3.98;
            mass[1] = 1;
            mass[2] = 0.02;

            var res = ds.LoadFromDataFile("");

            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(mass[i], res[i]);
            }
        }
    }
}