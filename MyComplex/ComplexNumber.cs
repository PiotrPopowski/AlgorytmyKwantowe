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
    }
}
