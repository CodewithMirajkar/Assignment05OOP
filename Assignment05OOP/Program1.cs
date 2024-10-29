//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment05OOP
//{

//    class Employee
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public double Salary { get; set; }

//        public virtual double CalSalary()
//        {
//            return Salary;
//        }
        
//    }

//    class FullTimeEmployee : Employee
//    {
//        public double Bonus { get; set; }

//        public override double CalSalary()
//        {
//            return Salary + Bonus;
//        }
//    }
//    class PartTimeEmployee : Employee
//    {
//        public double PartTimeSalary { get; set; }

//        public override double CalSalary()
//        {
//            return PartTimeSalary;
//        }
//    }

//    internal class Program1
//    {
//       static void Main(string[] args)
//        {
//            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
//            {
//                Name = "Nitin",
//                Age = 30,
//                Salary = 35000,
//                Bonus = 5000
//            };
//            Console.WriteLine($"Fulltime employee name :{fullTimeEmployee.Name}");
//            Console.WriteLine($"Fulltime employee age :{fullTimeEmployee.Age}");
//            Console.WriteLine($"Fulltime employee Salary :{fullTimeEmployee.Salary}");
//            Console.WriteLine($"Fulltime employee Bonus :{fullTimeEmployee.Bonus}");

//            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
//            {
//                Name = "Rahul",
//                Age = 25,
//                PartTimeSalary = 15000
//            };
            
//            Console.WriteLine($"Parttime employee name :{partTimeEmployee.Name}");
//            Console.WriteLine($"Parttime employee age :{partTimeEmployee.Age}");
//            Console.WriteLine($"Parttime employee Parttimesalay :{partTimeEmployee.PartTimeSalary}");
//            Console.ReadLine();
//        }
        
//    }
        
        

    
    
//}
