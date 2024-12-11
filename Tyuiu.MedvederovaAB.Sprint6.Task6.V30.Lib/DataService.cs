using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvederovaAB.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                string[] fragments;

                
                while ((line = reader.ReadLine()) != null)
                {
                    fragments = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    
                    result += fragments.Length >= 4 ? fragments[3] + " " : ""; 
                }
            }

            result = result.Trim(); 
            return result;
        }
    }
}
