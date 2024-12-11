using Tyuiu.MedvederovaAB.Sprint6.Task7.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint6\Tyuiu.MedvederovaAB.Sprint6.Task7.V10\bin\Debug\net8.0-windows\InPutDataFileTask7V10.csv";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
    
}