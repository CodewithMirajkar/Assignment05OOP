//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment05OOP
//{

//    public class Person
//    {
//        private string name;
//        private int age;

//        public void SetDetails(string personName, int personAge)
//        {
//            if (personAge > 0)
//            {
//                name = personName;
//                age = personAge;
//            }
//            else
//            {
//                Console.WriteLine("Please fill up correct Age");
//            }            
//        }

//        public string GetDetails()
//        {
//            return "Name: " + name+", Age: "+age;
//        }
//    }





//    internal class Program4
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person();
//            person.SetDetails("Ravi",25);
//            Console.WriteLine(person.GetDetails());
//            Console.ReadLine();
//        }
//    }
//}
