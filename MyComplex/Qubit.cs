using System;
using System.Collections.Generic;
using System.Text;

namespace MyComplex
{
    public class Qubit
    {
        public Vector vector { get; private set; }

        public ComplexNumber Alpha { get => vector.Values[0]; }
        public ComplexNumber Beta { get => vector.Values[1]; }

        public Qubit(ComplexNumber alpha, ComplexNumber beta)
        {
            setQubit(alpha, beta);
        }

        public Qubit()
        {
            ComplexNumber alpha = ComplexNumber.Random();
            ComplexNumber beta = ComplexNumber.FromPolarCoordinates(Math.Sqrt(1-Math.Pow(alpha.Magnitude,2)),ComplexNumber.Random().Phase);
            setQubit(alpha, beta);
        }

        private void setQubit(ComplexNumber alpha, ComplexNumber beta)
        {
            double d = Math.Abs(1 - (Math.Pow(alpha.Magnitude, 2) + Math.Pow(beta.Magnitude, 2)));
            if (Math.Abs(1 - (Math.Pow(alpha.Magnitude, 2) + Math.Pow(beta.Magnitude, 2))) > 0.00000001)
                throw new Exception("Given alpha and beta are not valid.");
            vector = new Vector(alpha, beta);
        }

        public static Qubit PauliX(Qubit qubit) => new Qubit(qubit.Beta, qubit.Alpha);

        public static Qubit PauliY(Qubit qubit) 
            => new Qubit(qubit.Beta * (new ComplexNumber(0, -1)), qubit.Alpha * (new ComplexNumber(0, 1)));

        public static Qubit PauliZ(Qubit qubit) 
            => new Qubit(qubit.Alpha, qubit.Beta*(-1));

        public static Qubit T(Qubit qubit)
            => new Qubit(qubit.Alpha, (qubit.Beta * (new ComplexNumber(1, 1)))/Math.Sqrt(2));

        public static Qubit Tt(Qubit qubit)
            => new Qubit(qubit.Alpha, (qubit.Beta * (new ComplexNumber(1, -1))) / Math.Sqrt(2));

        public static Qubit S(Qubit qubit)
            => new Qubit(qubit.Alpha, qubit.Beta * (new ComplexNumber(0, 1)));

        public static Qubit St(Qubit qubit)
            => new Qubit(qubit.Alpha, qubit.Beta * (new ComplexNumber(0, -1)));

        public static Qubit Hadamard(Qubit qubit) 
            => new Qubit((qubit.Alpha + qubit.Beta) / Math.Sqrt(2), (qubit.Alpha - qubit.Beta) / Math.Sqrt(2));

        public override string ToString()
        {
            return vector.ToString();
        }
    }
}
