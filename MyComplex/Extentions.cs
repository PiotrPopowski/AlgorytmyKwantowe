using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyComplex
{
    static class Extentions
    {
        public static ComplexNumber ToComplexNumber(this Complex c) => new ComplexNumber(c);
    }
}
