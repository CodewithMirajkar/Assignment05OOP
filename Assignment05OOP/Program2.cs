//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment05OOP
//{

//    abstract class Shape
//    {
//        public abstract double CalArea();

//    }
//    class Circle : Shape
//    {
//        public double Radius { get; set; }
//        public Circle(double radius)
//        {
//            Radius = radius;

//        }
//        public override double CalArea()
//        {
//            return Math.PI * Radius * Radius;
//        }

//    }

//    class Rectange : Shape
//    {
//        public double Lenth { get; set; }
//        public double Width { get; set; }

//        public Rectange(double lenth, double width)
//        {
//            Lenth = lenth;
//            Width = width;
            
//        }
//        public override double CalArea()
//        {
//            return Lenth * Width;
//        }
//    }



//    internal class Program2
//    {
//        static void Main(string[] args)
//        {
//            Shape circle = new Circle(10);
//            Console.WriteLine(circle.CalArea());
//            Shape rectange = new Rectange(10, 5);
//            Console.WriteLine(rectange.CalArea());
//            Console.ReadLine();


//        }

//    }
//}
