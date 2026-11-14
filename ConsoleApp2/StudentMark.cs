namespace ConsoleApp2
{
    public class StudentMark
    {
        public int Mark { get; set; }
        public int StudentId { get; }
        private int _totalMarks;
        public int Age { get; set; }
        protected int TotalMarks { get; set; }
        public string StudentName { get; set; }

        private int CalculateTest(int mark1, int mark2)
        {
            TotalMarks = 90;
            _totalMarks = mark1 + mark2;
            return _totalMarks;
        }

        public int CalculateTotalMarks(int[] marksArrayList)
        {
            CalculateTest(marksArrayList[0], marksArrayList[1]);
            _totalMarks = 0;
            foreach (var mark in marksArrayList)
            {
                _totalMarks += mark;
            }
            return _totalMarks;
        }
    }
}
