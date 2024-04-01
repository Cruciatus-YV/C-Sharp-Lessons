using TestApp.ClassCreate;

Console.WriteLine("Hello, World!\n");
var studentsList = new List<Student>()
{
    new ("Voronkin Yuriy Aleksandrovich", false, 5),
    new ("Gryn Bogdan Vasilievich", false, 4),
    new ()
    {
        Name = "Artem pohui",
        Course = 3,
        IsOnBudget = true,
    }
};
studentsList.ForEach(student => Console.WriteLine(student.ToString()));
Console.ReadLine();