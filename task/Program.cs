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
            //Task-6------------------------------------------------------------------------
            //Safe Division Calculator------------------------------------------------------
            
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            string classification;
            if (celsius < 10)
            {
                classification = "Cold";
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                classification = "Mild";
            }
            else
            {
                classification = "Hot";
            }

            Console.WriteLine($"Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Weather classification: {classification}");
            
            //Task-7------------------------------------------------------------
            //Movie Ticket Pricing----------------------------------------------

            Console.Write("Enter your age: ");
            int AGE = Convert.ToInt32(Console.ReadLine());

            string category;
            double price;

            if (AGE >= 0 && age <= 12)
            {
                category = "Children";
                price = 2.000;
            }
            else if (AGE >= 13 && age <= 59)
            {
                category = "Adults";
                price = 5.000;
            }
            else
            {
                category = "Seniors";
                price = 3.000;
            }

            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Ticket Price: {price:F3} OMR");
            
            //Task-8-------------------------------------------------
            //Restaurant Bill with Membership Discount----------------

            Console.Write("Enter the total bill amount: ");
            double billAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you a loyalty member? (yes/no): ");
            string isMember = Console.ReadLine();

            double discount = 0;

            if (billAmount > 20 && isMember == "yes")
            {
                discount = billAmount * 0.15;
            }

            double finalAmount = billAmount - discount;

            Console.WriteLine($"Original bill: {billAmount:F3} OMR");
            Console.WriteLine($"Discount amount: {discount:F3} OMR");
            Console.WriteLine($"Final amount to pay: {finalAmount:F3} OMR");
            
             //Task-9-------------------------------------------------------------
             //Day Name Finder----------------------------------------------------
        
            Console.Write("Enter a number (1-7) to find the day of the week: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            Console.WriteLine(dayName);
            
            //Task-10--------------------------------------------------------
            //Mini Calculator------------------------------------------------
            
                    // Ask the user for two numbers and an operator
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;
            bool isValid = true;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        isValid = false;
                    }
                    break;
                case '%':
                    if (num2 != 0)
                        result = num1 % num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        isValid = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine($"Result: {result}");
            }
            
            //Task-11----------------------------------------------------------
            //Loan Eligibility System------------------------------------------

            Console.Write("Enter your AgE: ");
            int AgE = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your monthly income (OMR): ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Do you have an existing loan? (yes/no): ");
            string hasLoan = Console.ReadLine();

            if (AgE >= 21 && AgE <= 60 && income >= 400 && hasLoan == "no")
            {
                Console.WriteLine("Congratulations! You are eligible for the loan.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for the following reason(s):");
            
                if (AgE < 21 || AgE > 60)
                {
                    Console.WriteLine("- Age out of range.");
                }
                if (income < 400)
                {
                    Console.WriteLine("- Income too low.");
                }
                if (hasLoan == "yes")
                {
                    Console.WriteLine("- Has an existing loan.");
                }
            }
            //Task-12-----------------------------------------------------
            //Shipping Cost CalculatorShipping Cost Calculator------------
            
            Console.Write("Enter region code (A, B, or C): ");
            char region = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Enter package weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double baseCost = 0;
            double extraCharge = 0;
            bool isvalid = true;

            switch (region)
            {
                case 'A':
                    baseCost = 1.000;
                    break;
                case 'B':
                    baseCost = 3.000;
                    break;
                case 'C':
                    baseCost = 7.000;
                    break;
                default:
                    Console.WriteLine("Invalid region");
                    isValid = false;
                    break;
            }

            if (isvalid)
            {
                if (weight > 10)
                {
                    extraCharge = 5.000;
                }
                else if (weight > 5)
                {
                    extraCharge = 2.000;
                }
                else
                {
                    extraCharge = 0;
                }

                double totalCost = baseCost + extraCharge;

                Console.WriteLine($"Base cost: {baseCost:F3} OMR");
                Console.WriteLine($"Extra charge: {extraCharge:F3} OMR");
                Console.WriteLine($"Total shipping cost: {totalCost:F3} OMR");
            }
        }
        
 
    }
}