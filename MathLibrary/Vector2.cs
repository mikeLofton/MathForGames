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

        //Create overload to check if two vectors are equal to each other and to check if 
        //two vectors are not equal to each other

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { X = lhs.X - rhs.X, Y = lhs.Y - rhs.Y };
        }

        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 result = new Vector2();

            result.X = lhs.X *= rhs;
            result.Y = lhs.Y *= rhs;

            return result;
        }

        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            Vector2 result = new Vector2();

            result.X = lhs.X /= rhs;
            result.Y = lhs.Y /= rhs;

            return result;
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {          
            if ( lhs.X == rhs.X && lhs.Y == rhs.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            if (lhs.X != rhs.X && lhs.Y != rhs.Y)
            {
                return true;
            }

            return false;
        }
    }
}
