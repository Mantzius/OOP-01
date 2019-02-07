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

        public void Scale(int Scalar)
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

        public Vector Scaled(int Scalar)
        {
            return new Vector(this.Magnitude * Scalar, this.Direction);

        }

        public void Print()
        {
            Console.WriteLine(String.Format("Magnitude: {0} Direction: {1}", this.Magnitude, this.Direction));
        }
    }
}
