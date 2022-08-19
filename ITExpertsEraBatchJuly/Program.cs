using System; // Add All the libraries. 

namespace ITExpertsEraBatchJuly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("My name is  Deepak!");
            // Console.WriteLine("I am Software Programmer");
            // Console.WriteLine("India is a great country");
            //Console.WriteLine("Hello World!");

            // this information is related to apple.
            //Console.Write("This is console.Write.");
            //Console.Write("This is second line");

            // sum function.
            //int firstValue = 10;
            //int secondValue = 20;

            //int result = firstValue + secondValue;

            //Console.WriteLine(result);

            // Get Value from users.

            //Console.WriteLine("Please Enter your first number");
            //int first = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter your second number");
            //int second = Convert.ToInt32(Console.ReadLine());

            //int sum = first + second;
            //int subtract = first - second;
            //int multiply = first * second;
            //int divide = first / second;

            //Console.WriteLine(sum);
            //Console.WriteLine(subtract);
            //Console.WriteLine(multiply);
            //Console.WriteLine(divide);

            /////////////////////////////////////////// 24th July 2022 ///////////////////////////////////////////////////

            //Console.WriteLine("Please Enter your Name ");
            //string studentName = Console.ReadLine();

            //Console.WriteLine("Please enter your maths number");
            //int mathsNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter your English number");
            //int englishNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter your Hindi number");
            //int hindiNumber = Convert.ToInt32(Console.ReadLine());

            //int studentMarks = mathsNumber + englishNumber + hindiNumber;
            //int totalMarks = 300;
            //int percentage = (studentMarks * 100) / totalMarks; // 180 * 100 /300 = 60 // BODMAS

            //Console.WriteLine("Total Marks of the student " + studentName + " is " + studentMarks); // concatenation of the string done by + symbol.

            //Console.WriteLine("Percentage of the Student " + studentName + "is " + percentage + "%");


            //// Data Types :


            //byte variableByte = 255;
            //uint variableUint = 4294967295u;
            //char variableChar = 'c';
            //bool varibleBool = true;
            //object variableObject = true;
            //string variableString = "this is a good class";
            //DateTime variableDatetime = DateTime.Now;

            // if else  :

            //Console.WriteLine("Please enter your numbers");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 70)
            //{
            //    Console.WriteLine("congratulations !! you got first Rank");
            //}
            //else if (number > 50 && number < 70)
            //{
            //    Console.WriteLine("congratulations !! you got second Rank");
            //}
            //else if ( number > 33 && number < 50)
            //{
            //    Console.WriteLine("congratulations !! you got third Rank");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry !! you are failed. Better Luck next time.");
            //}

            //Console.WriteLine("Please enter your total marks");

            //int totalMarks = Convert.ToInt32(Console.ReadLine());

            //if (number > 70 || totalMarks > 70 )
            //{
            //    Console.WriteLine("You got first in the school");
            //}


            //////////////////////////////////////////// 29 July 2022 /////////////////////////////////////////////////
            ///

            //MathsOperations objMathsOp = new MathsOperations(); // create new object of MathsOPerationClass.

            //int resultSum = objMathsOp.Sum(50, 100);

            //int resultSubtract = objMathsOp.Subtract(100, 50);

            //Console.WriteLine("Sum of the two numbers is " + resultSum);
            //Console.WriteLine("Subtraction of the two numbers is " + resultSubtract);

            //int[] resultArray = objMathsOp.GetArray();

            //// Syntax of for loop.
            //for (int i = 0; i < resultArray.Length; i++) // i++ = i = i+1;
            //{
            //    Console.WriteLine("Value of index " + i  + " is " + resultArray[i]);
            //}

            ////////////////////////////////// 31 July 2022 ////////////////////////////

            //MathsOperations objMaths = new MathsOperations();

            //int[] resultArray = objMaths.GetArray();

            //foreach (int item in resultArray)
            //{
            //    Console.WriteLine(item);
            //}

            //// Sum of the array's value. 

            //int result = 0;

            //foreach(int item in resultArray)
            //{
            //    result = result + item;
            //}

            //Console.WriteLine("Sum of the array is " + result);

            //// Operation on Array where value is greater than 30. 

            //foreach (int item in resultArray)
            //{
            //    if (item > 30)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine("=================== While Loop =====================");

            //// while Loop 
            //int i = 0;
            //while (i < resultArray.Length)
            //{
            //    Console.WriteLine(resultArray[i]);
            //    i++;
            //}

            //// Do While
            //Console.WriteLine("===================Do While Loop =====================");

            //int j = 0;
            //do
            //{
            //    Console.WriteLine(resultArray[j]);
            //    j++;
            //} while (j < resultArray.Length);


            //// Switch Case

            //Console.WriteLine("====================Switch Case ============================");

            //Console.WriteLine("Please Enter Your Week Number");

            //int week = Convert.ToInt32(Console.ReadLine());

            //switch (week)
            //{
            //    case 1:
            //        Console.WriteLine("Today is Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Today is Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Today is Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Today is Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Today is Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Today is Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("You have entered invalid value");
            //        break;
            //}

            //if (week == 1)
            //{
            //    Console.WriteLine("Today is Monday");
            //}
            //else if ( week == 2)
            //{
            //    Console.WriteLine("Today is Tuesday");
            //}
            //else
            //{
            //    Console.WriteLine("This is invalid value");
            //}


            // break vs continue


            //for (int i = 0; i < 10; i++) // 10, 20, 30, 40, 50
            //{
            //   if (i == 4 || i == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            ///////////////////////////////////////////// 05 August 2022 ////////////////////////////////

            //    // 1        //2//5     //4
            //for (int i = 0; i < 10; i++) // F10 or fn + F10 button for next step.
            //{
            //    // 3
            //    Console.WriteLine(i);
            //}

            // Sum and Average

            //int resultSum = 0;
            //int resultAverage = 0;

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    resultSum = resultSum + array[i]; // 0 + 1
            //}

            //resultAverage = resultSum / array.Length;

            //Console.WriteLine(resultSum);
            //Console.WriteLine(resultAverage);

            //TestClass objTestClass = new TestClass();

            //int result = objTestClass.GetValue();

            //string resultString = objTestClass.GetStringValue();

            //Console.WriteLine(result);
            //Console.WriteLine(resultString);

            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}


            // Interview Question : Swap Two Numbers

            //int i = 10;

            //int j = 20;

            //// Swap number technique 1
            ////int k = i;

            ////i = j;

            ////j = k;

            //// Swap Number technique 2 without using third variable.

            //i = i + j; // 30
            //j = i - j; // 10
            //i = i - j; // 20



            //Console.WriteLine(i); // 20
            //Console.WriteLine(j); // 10

            //int var1 = 100;

            //int result = var1 / 0;

            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");
            //Console.WriteLine("This is first line of the code");

            ///////////////////////////////////// 07 August 2022 ////////////////////////////

            //int i = 10; // value type
            //float j = 10.5f; // value type
            //string k = "This is sample"; // reference type.

            //TestClass objTestClass = new TestClass(); // refrence type

            //TestClass objTestClass2;

            //objTestClass2 = new TestClass();


            //TestClass objTestClass3 = new TestClass();

            ///////////////////////////// /////////////////////
            /////

            //TestClass objTestClass4 = objTestClass3;

            //objTestClass3.GetValue(); // 100

            //objTestClass3 = null;

            //objTestClass3.GetValue(); // runtime exception.

            //objTestClass4.GetValue(); // 100


            //Console.WriteLine("This is test Line");


            Car objCar = new Car();

            //objCar.CarName = "Honda City";
            objCar.CarType = "Sedan";
            objCar.NoofSeats = 4;
            objCar.Color = "Black";

            Console.WriteLine("Your Car Name is " + objCar.CarName + " Car type is " + 
                objCar.CarType + " And No of Seats are " + objCar.NoofSeats + " " +
                "Your car color is " + objCar.Color);

            Car objCar2 = new Car();

            objCar2 = objCar;

            objCar = null;

            Console.WriteLine("Your Car Name is " + objCar2.CarName + " Car type is " + 
                objCar2.CarType + " And No of Seats are " + objCar2.NoofSeats + " Your car color is " + 
                objCar.Color);

            Console.Read();
        }
    }
}


