using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestApp.Inheritance
{
    public interface IGetFullInfo
    {
        string GetFullInfo(); 
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string GetUserFullInfo() => new StringBuilder()
            .AppendLine($"{nameof(FirstName)} = {FirstName}")
            .AppendLine($"{nameof(LastName)} = {LastName}")
            .AppendLine($"{nameof(Age)} = {Age}")
            .ToString();
    }
   
    
}
