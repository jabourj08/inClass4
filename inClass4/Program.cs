using System;

using System.Threading.Tasks;
using System.Threading;

namespace inClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TOMMYS WAY
            //double RectArea = AreaRectangle(10, 5);
            //Console.WriteLine("Here's the area of the rectangle: " + RectArea);
            //double triArea = AreaTriangle(10, 5);
            //Console.WriteLine("Here's the area of the triangle: " + triArea);
            //double circleArea = AreaCircle(5);
            //Console.WriteLine("Here's the area of a circle: " + circleArea);
            //double rectPerimeter = PerimeterRectangle(10, 5);
            //Console.WriteLine("Here's the perimeter of our rectangle: " + rectPerimeter);
            //double circumference = Circumference(5);
            //Console.WriteLine("Here's the circumference of our circle: " + circumference);

            //MY WAY
            //CalcAreaRectangle();
            //CalcAreaCircle();
            //CalcAreaTriangle();
            //CalcPerimeterRectangle();
            //CalcPerimeterCircle();
            //CalcPythagorean();

            /*
            int[] nums = { 1903, 1991, 1953, 456 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            string fName = "Star";
            string lName = "Wars";

            string greeting = $"Hello {fName}, your last name is {lName}";

            Console.WriteLine(greeting);
            */

            
            //String Exercises || IndexOf, EndsWith() 

            string word = "C# is totally cool!";

            Console.WriteLine("Your word is " + word);
            Console.WriteLine("The first occurance of 'i' is in position " + word.IndexOf("i"));
            Console.WriteLine("The first occurance of 'totally' starts in position " + word.IndexOf("totally"));
            Console.WriteLine();

            string word2 = "This is my second example.";

            Console.WriteLine(word2.EndsWith("example."));
            Console.WriteLine(word2.EndsWith("example?"));

            string word3 = "Chop this thing up!";

            

            int age = 35;
            Console.WriteLine(age);

            string s = age.ToString();
            Console.WriteLine(s);

        }


        //TECHNIQUE 1
        public static void CalcAreaRectangle()
        {
            Console.WriteLine("Please enter Length of Rectangle");
            double length = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Width of Rectangle");
            double width = Double.Parse(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("The area of your Rectangle is: " + area);

        }

        public static void CalcAreaCircle()
        {
            Console.WriteLine("Please enter Radius of Circle");
            double radius = Double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area of your Circle is: " + area);
        }

        public static void CalcAreaTriangle()
        {
            Console.WriteLine("Please enter Base of triangle");
            double tBase = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Height of your triangle");
            double tHeight = Double.Parse(Console.ReadLine());

            double area = (tBase * tHeight) / 2;

            Console.WriteLine("The area of your Triangle is: " + area);
        }

        public static void CalcPerimeterRectangle()
        {
            Console.WriteLine("Please enter Length of Rectangle");
            double length = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Width of Rectangle");
            double width = Double.Parse(Console.ReadLine());

            double perimeter = (length * 2) + (width * 2);

            Console.WriteLine("The perimeter of your Rectangle is: " + perimeter);

        }

        public static void CalcPerimeterCircle()
        {
            Console.WriteLine("Please enter Radius of Circle");
            double radius = Double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("The perimeter of your Circle is: " + perimeter);
        }

        public static void CalcPythagorean()
        {
            Console.WriteLine("Please enter Side 1: ");
            double a = Double.Parse(Console.ReadLine());
            a = Math.Pow(a, 2);

            Console.WriteLine("Please enter Side 2: ");
            double b = Double.Parse(Console.ReadLine());
            b = Math.Pow(b, 2);

            double c = Math.Sqrt((a + b));

            Console.WriteLine("The perimeter of your circle is: " + c);
        }




        //TECHNIQUE 2
        public static double AreaRectangle(double width, double length)
        {
            double rectangleArea = width * length;
            return rectangleArea;
        }
        public static double AreaTriangle(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
        public static double AreaCircle(double radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }
        public static double PerimeterRectangle(double width, double length)
        {
            double perimeter = (2 * width) + (2 * length);
            return perimeter;
        }
        public static double Circumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }


    }
}
