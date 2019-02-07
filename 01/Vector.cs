using System;
namespace Application
{
    class Vector
    {
        private float Magnitude;
        private float Direction;

        public Vector(float Magnitude, float Direction)
        {
            this.Magnitude = Magnitude;
            this.Direction = Direction;
        }

        public void Add(Vector AddVector)
        {
            this.Magnitude += AddVector.Magnitude;
            this.Direction += AddVector.Direction;
        }

        public void Subtract(Vector SubVector)
        {
            this.Magnitude -= SubVector.Magnitude;
            this.Direction -= SubVector.Direction;
        }

        public void Multiply(int Scalar)
        {
            Magnitude *= Scalar;
        }

        public Vector Addition(Vector AddVector)
        {
            return new Vector(this.Magnitude + AddVector.Magnitude,
                              this.Direction + AddVector.Direction);
        }

        public Vector Subtraction(Vector SubVector)
        {
            return new Vector(this.Magnitude - SubVector.Magnitude,
                              this.Direction - SubVector.Direction);
        }

        public Vector Multiplication(int Scalar)
        {
            return new Vector(this.Magnitude * Scalar, this.Direction);

        }

        public void Print()
        {
            Console.WriteLine("Magnitude: " + this.Magnitude + " Direction: " + this.Direction);
        }
    }
}
