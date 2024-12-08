using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvederovaAB.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] sortedMatrix = (int[,])matrix.Clone(); 

            int[] indices = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                indices[i] = i; 
            }

            Array.Sort(indices, (a, b) => sortedMatrix[a, 2].CompareTo(sortedMatrix[b, 2]));

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int sortedIndex = indices[i];
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = sortedMatrix[sortedIndex, j]; 
                }
            }

            return result;
        }
    }
}
