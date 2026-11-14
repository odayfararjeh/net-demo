using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class DataService : IDataService
    {
        public string GetData()
        {
            return "Hello from DataService!";
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
