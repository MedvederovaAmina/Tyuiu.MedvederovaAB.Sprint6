using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvederovaAB.Sprint6.Task5.V23.Lib
{
    public class DataService : ISprint6Task5V23
    {
        public int Length = 0;
        public double[] LoadFromDataFile(string path)
        {
            

            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Length++;
                }
            }

            double[] valueArray = new double[Length];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    valueArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            
            valueArray = valueArray.Where(val => val < 0).ToArray();
            return valueArray;
        }
    }
}
