using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_methods
{
    public enum Group
    {
        fizik,
        Matematic,
        Himik,
        IT
    }
    public class Student
    {
        public Guid Id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public Group group;

        public void Print()
        {
            Console.WriteLine("info obout Student");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"lastName: {lastName}");
            Console.WriteLine($"firstName: {firstName}");
            Console.WriteLine($"middleName: {middleName}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"group: {group}");
        }
        
        public void GetFullName()
        {
            Console.WriteLine($"{firstName} {lastName} {middleName}");
        }

    }
}
