using Bogus;

Console.WriteLine("Analog data generation");
var result = GetClassGrade();
foreach (var grade in result)
{
    Console.WriteLine(grade.ClassName);
    Console.WriteLine(grade.ClassIndex);
    // foreach (var student in grade.Students)
    // {
    //      Console.WriteLine(student.Address);
    //         Console.WriteLine(student.Age);
    //         Console.WriteLine(student.Email);
    //         Console.WriteLine(student.Id);
    //         Console.WriteLine(student.Name);
    // }
    Console.WriteLine("******************");
}

Console.ReadKey();

List<ClassGrade> GetClassGrade()
{
    var student =
        new Faker<Student>()
            .RuleFor(o => o.Address, f=>f.Person.Address.City)
            .RuleFor(o => o.Age, f => f.IndexFaker)
            .RuleFor(o => o.Id, Guid.NewGuid)
            .RuleFor(o => o.Email, f => f.Person.Email)
            .RuleFor(o => o.Name, f => f.Person.FullName);
    var classGrade = new Faker<ClassGrade>().RuleFor(o => o.ClassName, f => f.Name.LastName())
        .RuleFor(o => o.ClassIndex, f => f.Person.UserName)
        .RuleFor(o => o.Students, f => student.Generate(50));
    return classGrade.Generate(5);
}