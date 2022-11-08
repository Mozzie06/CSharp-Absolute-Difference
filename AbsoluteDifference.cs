using System;

namespace AbsoluteDifference

{

    class AbsoluteDiff

    { 

        static void Main(string[]args)

        {

            Console.Write("Input first number: ");

            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Input second number: ");

            int secondNum = int.Parse(Console.ReadLine());

            Console.Write("Absolute Difference: ");

            Console.WriteLine(Absolute(firstNum, secondNum));

        }

        

        static int Absolute(int fNum, int sNum){

            

            if(fNum > sNum){

                return fNum - sNum;

            }

                return sNum - fNum;

        }

    }

}

