namespace ConsoleApp2
{
    public class localclass : newClass
    {
        public override int CalculateTotalMarks(int[] marksArrayList)
        {
            int totalMarks = 0;
            foreach (var mark in marksArrayList)
            {
                totalMarks += mark;
            }
            return totalMarks;
        }
    }
}
