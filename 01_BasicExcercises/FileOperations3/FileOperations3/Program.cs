using System.IO;
using System.Reflection;
namespace FileOperations3
{
    public static class Program
    {

        public static void Main(string[] args)
        {
           
        }

        private static void PrintFile(List<string> systemConfig)
        {
            foreach (var item in systemConfig)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> ReadFile(List<string> systemConfig, string directory, string filePath)
        {

            StreamReader reader = new StreamReader(directory + filePath);
            try
            {
                do
                {
                    systemConfig.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }
            catch
            {
                systemConfig.Add(("File is empty"));
            }
            finally
            {
                reader.Close();
            }
            return systemConfig;
        }
    }
}
