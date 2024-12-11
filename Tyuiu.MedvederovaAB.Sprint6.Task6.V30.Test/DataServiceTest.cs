using Tyuiu.MedvederovaAB.Sprint6.Task6.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}