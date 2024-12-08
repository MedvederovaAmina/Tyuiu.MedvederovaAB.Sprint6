using Tyuiu.MedvederovaAB.Sprint6.Task5.V23.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint6\Tyuiu.MedvederovaAB.Sprint6.Task5.V23\bin\Debug\net8.0-windows\InPutDataFileTask5V23.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}