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

            /*Vector v1 = new Vector(new ComplexNumber(-2, 5), new ComplexNumber(8, -6), new ComplexNumber(4, 5));
            Vector v2 = new Vector(new ComplexNumber(5, 7), new ComplexNumber(3, 6), new ComplexNumber(2, 2));
            Console.WriteLine("v1={0}",v1);
            Console.WriteLine("v2={0}",v2);
            Console.WriteLine("Iloczyn skalarny: {0}", Vector.ScalarProduct(v1, v2));
            Console.WriteLine("Suma: {0}", Vector.Add(v1, v2));
            Console.WriteLine("Norma: {0}", Vector.Norm(v2));*/
            Qubit q1= new Qubit();
            Console.WriteLine("q1={0}", q1);
            Console.WriteLine("Phase alpha: {0}", q1.Alpha.Phase);
            Console.WriteLine("Phase beta: {0}", q1.Beta.Phase);
            Console.WriteLine("X gate {0}", Qubit.PauliX(q1));
            Console.WriteLine("X alpha phase {0}", Qubit.PauliX(q1).Alpha.Phase);
            Console.WriteLine("X beta phase {0}", Qubit.PauliX(q1).Beta.Phase);

            Console.WriteLine("S gate {0}", Qubit.S(q1));
            Console.WriteLine("S alpha phase {0}", Qubit.S(q1).Alpha.Phase);
            Console.WriteLine("S beta phase {0}", Qubit.S(q1).Beta.Phase);

            Console.WriteLine("T gate {0}", Qubit.T(q1));
            Console.WriteLine("T alpha phase {0}", Qubit.T(q1).Alpha.Phase);
            Console.WriteLine("T beta phase {0}", Qubit.T(q1).Beta.Phase);
            
            ComplexNumber e=Calculator.Exp(new ComplexNumber(0, Math.PI / 4));
            Vector w = new Vector(1, e + 1);
            Console.WriteLine("w={0}", Vector.ScalarProduct(w,w));


            Console.WriteLine("Magnitude alpha: {0}", Math.Pow(q1.Alpha.Magnitude,2));
            Console.WriteLine("Magnitude beta: {0}", Math.Pow(q1.Beta.Magnitude,2));
            q1 = new Qubit(0, 1);
            var w1 = new Vector(4, 2, -1, 4, new ComplexNumber(1, -3), 4, 0, 1, 2, 3, 4);
            Console.WriteLine(w1);
            Console.WriteLine(q1);
            Console.WriteLine("Z: {0}", Qubit.S(q1));
            Console.WriteLine("Measure: {0}", Qubit.Measure(q1));
            Console.ReadLine();
        }
    }
}
