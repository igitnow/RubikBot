using System;

namespace RubikBot.Model.Geometry
{
    public class Vector
    {
        public Vector(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        

        public bool InPlane(Plane plane)
        {
            return X * plane.Normal.X + Y * plane.Normal.Y + Z * plane.Normal.Z == plane.d;
        }
        public static bool operator == (Vector vector1, Vector vector2)
        {
            if (ReferenceEquals(vector1, vector2))
                return true;
            if (ReferenceEquals(vector1, null))
                return false;
            if (ReferenceEquals(vector2, null))
                return false;

            return (vector1.X == vector2.X && vector1.Y == vector2.Y && vector1.Z == vector2.Z);

        }

        public static bool operator !=(Vector vector1, Vector vector2) => !(vector1 == vector2);
    }
}
