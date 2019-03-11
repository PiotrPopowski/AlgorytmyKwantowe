using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyComplex
{
    public static class ComplexCalculator
    {
        public static ComplexNumber Add(params ComplexNumber[] values)
        {
            Complex number = Complex.Zero;
            foreach (ComplexNumber c in values)
                number = Complex.Add(number, c.Complex);
            return number.ToComplexNumber();
        }

        public static ComplexNumber Subtract(params ComplexNumber[] values)
        {
            Complex number = values[0].Complex;
            values[0] = new ComplexNumber(0,0);
            foreach (ComplexNumber c in values)
                number = Complex.Subtract(number, c.Complex);
            return number.ToComplexNumber();
        }

        public static ComplexNumber Pow(ComplexNumber value, double pow) 
            => Complex.Pow(value.Complex, pow).ToComplexNumber();
        
        public static ComplexNumber Multiply(params ComplexNumber[] values)
        {
            Complex number = Complex.One;
            foreach (ComplexNumber c in values)
                number = Complex.Multiply(number, c.Complex);
            return number.ToComplexNumber();
        }

        public static ComplexNumber Divide(ComplexNumber dividend, ComplexNumber divisor) 
            => Complex.Divide(dividend.Complex, divisor.Complex).ToComplexNumber();

        public static ComplexNumber Exp(ComplexNumber number)
            => Complex.Exp(number.Complex).ToComplexNumber();

    }
}
