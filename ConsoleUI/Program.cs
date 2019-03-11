using MyComplex;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ComplexNumber number = new ComplexNumber(8, -6);
            ComplexNumber number2 = ComplexNumber.FromPolarCoordinates(10, 90*Math.PI/180);
            Console.WriteLine("Number 1: {0}", number);
            Console.WriteLine("Number 2: {0}", number2);
            Console.WriteLine("Degree 2: {0}", number2.Degrees);
            Console.WriteLine("Magnitude: {0}", number.Magnitude);
            Console.WriteLine("Magnitude2: {0}", number2.Magnitude);
            Console.WriteLine("Phase: {0}", number.Phase);
            Console.WriteLine("Phase2: {0}", number2.Phase);
            Console.WriteLine("Multiply Complex: {0}", ComplexCalculator.Multiply(number,number2.Conjugate()));
            Console.WriteLine("Multiply: {0}", Calculator.Multiply(number,number2.Conjugate()));
            Console.WriteLine("Add Complex: {0}", ComplexCalculator.Add(number, number2));
            Console.WriteLine("Add: {0}", Calculator.Add(number, number2));
            Console.WriteLine("Substract Complex: {0}", ComplexCalculator.Subtract(number, number2));
            Console.WriteLine("Substract: {0}", Calculator.Subtract(number, number2));
            Console.WriteLine("Divide Complex: {0}", ComplexCalculator.Divide(number, number2));
            Console.WriteLine("Divide: {0}", Calculator.Divide(number, number2));
            Console.WriteLine("Exp Complex: {0}", ComplexCalculator.Exp(number));
            Console.WriteLine("Exp: {0}", Calculator.Exp(number));
            Console.WriteLine("Pow Complex: {0}", ComplexCalculator.Pow(number,3));
            Console.WriteLine("Pow : {0}", Calculator.Pow(number,3));*/

            Vector v1 = new Vector(new ComplexNumber(3, -1), new ComplexNumber(2, 1), new ComplexNumber(5, 0), new ComplexNumber(0, 0));
            Vector v2 = new Vector(new ComplexNumber(0, -1), new ComplexNumber(-1, 0), new ComplexNumber(3, -1), new ComplexNumber(-1, -1));
            Console.WriteLine("v1={0}",v1);
            Console.WriteLine("v2={0}",v2);
            Console.WriteLine("Iloczyn skalarny: {0}", Vector.ScalarProduct(v1, v2));
            Console.WriteLine("Suma: {0}", Vector.Add(v1, v2));
            Console.WriteLine("Norma: {0}", Vector.Norm(v1));

            Console.ReadLine();
        }
    }
}
