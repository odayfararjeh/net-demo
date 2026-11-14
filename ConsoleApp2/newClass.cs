namespace ConsoleApp2
{
    public abstract class newClass
    {
        public abstract int CalculateTotalMarks(int[] marksArrayList);

        public string FindStudentName(int studentId)
        {
            return "Student Name";
        }

        public void DisplayStudentInfo(int studentId)
        {
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Student Name: {FindStudentName(studentId)}");
        }
    }
}
