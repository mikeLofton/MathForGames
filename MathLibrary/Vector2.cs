using System;

namespace MathLibrary
{
    public struct Vector2
    {
        public float X;
        public float Y;

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { X = lhs.X + rhs.X, Y = lhs.Y + rhs.Y };
        }

        //Create overloaded functions for subtraction with a vector, 
        //multiplication with a scalar, division with a scalar.

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { X = lhs.X - rhs.X, Y = lhs.Y - rhs.Y };
        }
    }
}
