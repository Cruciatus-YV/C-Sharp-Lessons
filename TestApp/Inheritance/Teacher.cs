using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Inheritance
{
    public interface ITeacher
    {
        decimal Selery { get; set; }
    }
    public interface IFedTeacher
    {
        double SportRate { get; set; }
    }
    public class FedTeacher : User, ITeacher, IFedTeacher, IGetFullInfo
    {
        public decimal Selery { get; set; }
        public double SportRate { get; set; }
        public string GetFullInfo() => new StringBuilder()
            .AppendLine($"{nameof(FirstName)} = {FirstName}")
            .AppendLine($"{nameof(LastName)} = {LastName}")
            .AppendLine($"{nameof(Age)} = {Age}")
            .AppendLine($"{nameof(Selery)} = {Selery}")
            .ToString();
    }
}
