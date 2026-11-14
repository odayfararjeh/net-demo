using ConsoleApp2;

var obj = new StudentMark();

obj.Mark = 85;
obj.StudentName = "John Doe";
Console.WriteLine(obj.Mark);

//var obj1 = new TestClass();

//obj1.Mark = 90;
//obj1.StudentName = "Jane Smith";
//obj1.CalculateTotalMarks(new int[] { 80, 90, 85 });


//IParentClass obj2 = new localclass();
//obj2.CalculateTotalMarks(new int[] { 70, 75, 80 });
//IParentClass obj3 = new TestClass();
//obj3.CalculateTotalMarks(new int[] { 70, 75, 80 });

var obj4 = new localclass();
obj4.FindStudentName(123);
obj4.DisplayStudentInfo(123);
