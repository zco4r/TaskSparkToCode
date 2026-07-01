namespace CombinedTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK -1------------------------------------------------------
            //Personal Info Card--------------------------------------------
            string name = "Ammar";
            int age = 19;
            double height = 1.72;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);
            
            
            Console.WriteLine();

          
        // TASK -2--------------------------------------------------------------
        //Rectangle Calculator--------------------------------------------------
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            
            // TASK -3-----------------------------------------------------------
            //Even or Odd Checker------------------------------------------------
            
            Console.Write("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even.");
            }
            else
            {
                Console.WriteLine(number + " is Odd.");
            }
            
            // TASK -4--------------------------------------------------------
            // Voting Eligibility---------------------------------------------

            Console.Write("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Do you have a valid national ID? (yes/no): ");
            string idInput = Console.ReadLine();

            bool hasID = (idInput == "yes");

            if (age >= 18 && hasID)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            
            // TASK -5---------------------------------------------------------------
            //Grade Letter Lookup----------------------------------------------------
            Console.Write("Enter a grade (A, B, C, D, or F): ");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }



            
        }
    }
}