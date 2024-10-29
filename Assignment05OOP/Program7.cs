//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment05OOP
//{

//    public class Employee
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Employee(string name, int age) 
//        {
//            Name = name;
//            Age = age;
//        }
//    }

//    public class Manager : Employee
//    {
//        public string Department {get; set; }

//        public Manager(string name, int age, string department): base(name, age)       
//        {            
//           Department = department;
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine("Manager Name: {0}, Age : {1}, & Department : {2}", Name, Age, Department);
//        }

//    }

    


//    internal class Program7
//    {
//        static void Main(string[] args)
//        {
//            Manager manager = new Manager("Kiran", 35, "OPS Team");
//            manager.DisplayDetails();
//            Console.ReadLine();
//        }
//    }
//}
