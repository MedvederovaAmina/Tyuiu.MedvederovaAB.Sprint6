using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvederovaAB.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] sortedMatrix = (int[,])matrix.Clone();

            
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (sortedMatrix[j, 2] > sortedMatrix[j + 1, 2])
                    {
                       
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = sortedMatrix[j, k];
                            sortedMatrix[j, k] = sortedMatrix[j + 1, k];
                            sortedMatrix[j + 1, k] = temp;
                        }
                    }
                }
            }

            return sortedMatrix;
        }
    }
}
