using Tyuiu.MedvederovaAB.Sprint6.Task3.V25.Lib;

namespace Tyuiu.MedvederovaAB.Sprint6.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int[,] matrix = new int[5, 5]
               { { 14, 5, -9, 18, 21 }, { -5, -12, -12, 4, 28 }, { 27, -2, -14, 23, 27 },{ -19, -15, 17, 15, 1 },{ 33, 2, 6, 24, 24 }};
          

            DataService ds = new DataService();
            int[,] sortedMatrix = ds.Calculate(matrix);

           
            Assert.AreEqual(-14, sortedMatrix[0, 2]);
            Assert.AreEqual(-12, sortedMatrix[1, 2]);
            Assert.AreEqual(-9, sortedMatrix[2, 2]);
            Assert.AreEqual(6, sortedMatrix[3, 2]);
            Assert.AreEqual(17, sortedMatrix[4, 2]);
        }
    }
}