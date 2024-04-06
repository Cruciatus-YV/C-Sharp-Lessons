using System.Text;
using TestApp.ClassCreate;
using TestApp.Inheritance;

Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Hello, World!\n");
//var studentsList = new List<Student>()
//{
//    new ("Voronkin Yuriy Aleksandrovich", false, 5),
//    new ("Gryn Bogdan Vasilievich", false, 4),
//    new ()
//    {
//        Name = "Artem pohui",
//        Course = 3,
//        IsOnBudget = true,
//    }
//};
//studentsList.ForEach(student => Console.WriteLine(student.ToString()));
//Console.ReadLine();

var users = new List<User>()
{
    new User()
    {
        FirstName = "Антон",
        LastName = "Андреев",
        Age = 32
    },
    new FedTeacher
    {
        FirstName = "Виктор",
        LastName = "Орлов",
        Age = 32,
        Selery = 160_000,
    } 
};
foreach (var user in users)
{
    Console.WriteLine(user is IGetFullInfo ? ((IGetFullInfo)user).GetFullInfo() : user.GetUserFullInfo());
    //Console.WriteLine(user.GetUserFullInfo());
    //if (user is ITeacher) {
    //    Console.WriteLine(((ITeacher)user).Selery);
    //}
}
Console.ReadLine();