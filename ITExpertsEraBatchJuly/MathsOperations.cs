using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraBatchJuly
{
    class MathsOperations
    {
        // Add
        public int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        // Subtract
        public int Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;

            return result;

           
        }

        // Multiply

        // Divide.

        //Array
        public int[] GetArray()
        {
            int[] array1 = new int[5]; // 4 * 5 byte

            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;

            return array1;
        }


    }
}
