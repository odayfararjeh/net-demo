namespace ConsoleApp2
{
    public interface IParentClass
    {
        int Mark { get; set; }
        double CalculateTotalMarks(int[] marksArrayList);
        string StudentName { get; set; }
    }
}
