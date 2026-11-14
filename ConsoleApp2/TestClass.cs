using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class TestClass : StudentMark, IParentClass
    {
        private readonly IDataService _dataService;
        public TestClass(IDataService dataService)
        {
            _dataService = dataService;
        }

        string IParentClass.StudentName { get => StudentName; set => StudentName = value; }

        public void DisplayMarks()
        {
            TotalMarks = 100;
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine($"Student Name: {StudentName}");
        }

        public double CalculateTotalMarks(int[] marksArrayList)
        {
            int a = 0;
            int b = 5;

            return a * b;
        }
    }
}
