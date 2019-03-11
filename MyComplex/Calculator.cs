using System;
using System.Collections.Generic;
using System.Text;

namespace MyComplex
{
    public static class Calculator
    {
        public static ComplexNumber Add(params ComplexNumber[] values)
        {
            double real=0;
            double imaginary=0;
            foreach (ComplexNumber c in values)
            {
                real += c.Real;
                imaginary += c.Imaginary;
            }
            return new ComplexNumber(real,imaginary);
        }

        public static ComplexNumber Subtract(params ComplexNumber[] values)
        {
            double real = values[0].Real;
            double imaginary = values[0].Imaginary;
            values[0] = new ComplexNumber(0,0);
            foreach (ComplexNumber c in values)
            {
                real = real - c.Real;
                imaginary = imaginary - c.Imaginary;
            }
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber Pow(ComplexNumber value, double pow)
        {
            double magnitude = Math.Pow(value.Magnitude, pow);
            double phase = value.Phase * pow;
            return ComplexNumber.FromPolarCoordinates(magnitude, phase);
        }

        public static ComplexNumber Multiply(params ComplexNumber[] values)
        {
            double real = 1;
            double imaginary = 0;
            double tempReal, tempImaginary;
            foreach (ComplexNumber c in values)
            {
                tempReal = c.Real*real + c.Imaginary*imaginary*(-1);
                tempImaginary = real*c.Imaginary+imaginary*c.Real;
                real = tempReal;
                imaginary = tempImaginary;
            }
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber Divide(ComplexNumber dividend, ComplexNumber divisor)
        {
            double denominator = Math.Pow(divisor.Real, 2) + Math.Pow(divisor.Imaginary, 2);
            ComplexNumber numerator = Multiply(dividend, divisor.Conjugate());
            return Multiply(numerator, new ComplexNumber(Math.Pow(denominator,-1), 0));
        }

        public static ComplexNumber Exp(ComplexNumber number)
        {
            double magnitude = Math.Pow(Math.E, number.Real);
            return ComplexNumber.FromPolarCoordinates(magnitude, number.Imaginary);
        }

    }
}
