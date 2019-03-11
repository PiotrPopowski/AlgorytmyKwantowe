using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyComplex
{
    public class Vector
    {
        private ComplexNumber[] _values;
        public ComplexNumber[] Values { get => _values; }
        public int Size { get => _values.Length; }

        public Vector(params ComplexNumber[] values)
        {
            _values = values;
        }

        public static Vector Add(params Vector[] values)
        {
            var vector = Vector.Zero(values[0].Size);
            foreach(Vector v in values)
            {
                for(int i=0; i<v.Size; i++)
                {
                    vector.Values[i] = Calculator.Add(vector._values[i], v._values[i]);
                }
            }
            return vector;
        }

        public static Vector Multiply(ComplexNumber s, Vector v)
        {
            Vector vector = Vector.Zero(v.Size);
            for(int i=0; i<v.Size; i++)
            {
                vector._values[i] = Calculator.Multiply(v._values[i], s);
            }
            return vector;
        }

        public static ComplexNumber ScalarProduct(Vector v1, Vector v2)
        {
            ComplexNumber c = new ComplexNumber(0,0);
            for(int i=0;i<v1.Size;i++)
            {
                c = Calculator.Add(c,Calculator.Multiply(v1._values[i], v2._values[i].Conjugate()));
            }
            return c;
        }

        public static ComplexNumber Norm(Vector vector)
        {
            ComplexNumber c = ScalarProduct(vector, vector);
            return Calculator.Pow(c, 0.5);

        }

        public static Vector Zero(int size)
        {
            var vector = new ComplexNumber[size];
            for(int i=0; i<size; i++)
                vector[i] = new ComplexNumber(0, 0);

            return new Vector(vector);
        }

        public override string ToString()
        {
            string x="[";
            int n = _values.Length;
            for (int i = 0; i < n; i++)
            {
                x += _values[i];
                if (i + 1 < n) x += ", ";
            }
            x += "]";
            return x;
        }
    }
}
