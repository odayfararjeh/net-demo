namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public int SchoolId { get; set; }
        private static int _nextId = 1;
        public List<Test> Tests { get; set; }
    }

    public class  Test
    {
        public int Id { get; set; }
    }
}
