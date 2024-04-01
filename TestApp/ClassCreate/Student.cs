using System.Text;

namespace TestApp.ClassCreate
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public byte? Course { get; set; }
        public bool IsOnBudget { get; set; }
        public Student() { }
        public Student(string name, bool isOnBudget, byte? course = null, Guid? id = null)
        {
            Name = name;
            IsOnBudget = isOnBudget;
            Course = course;
            if (id.HasValue)
            {
                Id = id.Value;
            }
        }
        public override string ToString() => new StringBuilder()
                .AppendLine($"Studen's id: {Id}")
                .AppendLine($"Full name: {Name}")
                .AppendLine($"Course: {Course}")
                .AppendLine($"Budget: {IsOnBudget}")
                .ToString();
    }
}
