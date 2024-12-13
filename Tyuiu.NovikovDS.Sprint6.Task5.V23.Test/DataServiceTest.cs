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
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V23.txt");

            int len = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) len++;
            }

            Assert.AreEqual(20, len);
        }
    }
}