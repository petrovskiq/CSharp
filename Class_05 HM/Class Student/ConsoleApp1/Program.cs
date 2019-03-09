using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] Students = new Student[5];
            Students[0] = new Student("Martin", "SEDC", "G2");
            Students[1] = new Student("Dario", "SEDC", "G2");
            Students[2] = new Student("Petar", "SEDC", "G2");
            Students[3] = new Student("Vanco", "Semos", "A");
            Students[4] = new Student("Riste", "Codecademy", "A");

            Console.WriteLine("Enter the name of the students that you want to find");

            var userInput = Console.ReadLine();

            var found = false;
            foreach (var item in Students)

            {
                if (userInput == item.Name)
                {
                    found = true;
                    if (found)
                    {
                        Console.WriteLine($"Student Information: \n Name: {item.Name} \n Academy:{item.Academy} \n Group: {item.Group}");
                    }
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Invalid User");
            }
           
            Console.ReadLine();

        }
    }

    public class Student
    {
        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
    }
}
