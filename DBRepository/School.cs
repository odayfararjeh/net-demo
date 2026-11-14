namespace DBRepository
{
    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Student>? Students { get; set; }
    }
}
