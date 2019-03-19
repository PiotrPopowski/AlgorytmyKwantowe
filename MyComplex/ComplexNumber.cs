using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyComplex
{
    public class ComplexNumber
    {
        public double Imaginary { get => Complex.Imaginary; }
        public double Real { get => Complex.Real; }
        public double Magnitude { get => Complex.Magnitude; } //Modul
        public double Degrees { get => Complex.Phase * (180 / Math.PI); }
        public double Phase { get => Complex.Phase; }
        public Complex Complex { get; private set; }

        public ComplexNumber(double real, double imaginary)
        {
            Complex = new Complex(real, imaginary);
        }

        public ComplexNumber(Complex complex)
        {
            Complex = complex;
        }

        public static ComplexNumber FromPolarCoordinates(double magnitude, double phase)
        {
            return new ComplexNumber(magnitude*Math.Cos(phase),magnitude*Math.Sin(phase));
        }

        public ComplexNumber Conjugate() => Complex.Conjugate(this.Complex).ToComplexNumber();

        public override string ToString()
        {
            if (Imaginary == 0) return Real.ToString();
            if (Imaginary < 0) return Real + " - " + Math.Abs(Imaginary)+"i";
            return Real + " + " + Imaginary + "i";
        }

        public static ComplexNumber Random()
        {
            System.Random rand = new Random();
            double a = rand.NextDouble();
            return ComplexNumber.FromPolarCoordinates(a, rand.Next(1,360)*Math.PI/180);
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) => ComplexCalculator.Add(a, b);
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) => ComplexCalculator.Subtract(a, b);
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) => ComplexCalculator.Multiply(a, b);
        public static ComplexNumber operator *(ComplexNumber a, double b) => ComplexCalculator.Multiply(a, new ComplexNumber(b, 0));
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b) => ComplexCalculator.Divide(a, b);
        public static ComplexNumber operator /(ComplexNumber a, double b) => ComplexCalculator.Divide(a, new ComplexNumber(b, 0));
        public static implicit operator ComplexNumber(double d) => new ComplexNumber(d, 0);
    }
}
