using ConsoleApp1;

var test = new List<Student>()
{
    new Student() { Id = 1, Name = "John Doe", Mark = 85, SchoolId = 1, Tests = new List<Test>() { new Test() { Id = 1 }, new Test() { Id = 2 } } },
    new Student() { Id = 2, Name = "Jane Smith", Mark = 92, SchoolId = 1, Tests = new List<Test>() { new Test() { Id = 3 }, new Test() { Id = 4 } } },
    new Student() { Id = 3, Name = "Alice Johnson", Mark = 78, SchoolId = 2, Tests = new List<Test>() { new Test() { Id = 5 }, new Test() { Id = 6 } } },
    new Student() { Id = 4, Name = "Bob Brown", Mark = 88, SchoolId = 2, Tests = new List<Test>() { new Test() { Id = 7 }, new Test() { Id = 8 } } },
    new Student() { Id = 5, Name = "Charlie Green", Mark = 90, SchoolId = 1, Tests = new List<Test>() { new Test() { Id = 9 }, new Test() { Id = 10 } } },
    new Student() { Id = 6, Name = "James Carl", Mark = 88, SchoolId = 2, Tests = new List<Test>() { new Test() { Id = 11 }, new Test() { Id = 12 } } },
    new Student() { Id = 7, Name = "Klode Mark", Mark = 90, SchoolId = 1, Tests = new List<Test>() { new Test() { Id = 13 }, new Test() { Id = 14 } } }
};

int i = 0;

var result2 = test.SelectMany(std => std.Tests).ToList();
var result = test.Select(std => std.Tests).ToList();
var result3 = test.Select(std => std.Id).Where(std => std >= 4).OrderBy(std => std).ToList();
var result4 = test.Where(std => std.Id >= 4).Select(std => std.Mark).OrderByDescending(std => std).ToList();
