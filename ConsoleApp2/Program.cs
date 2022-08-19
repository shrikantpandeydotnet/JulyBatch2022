using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = 10;
            int secondNumber = 20;

            int result = firstNumber + secondNumber;

            byte varByte = 255;

            Console.WriteLine(result);

            // Create object 

            Car objCar = new Car();

            objCar.Accelerator();
            Console.ReadLine();

        }
    }
}
