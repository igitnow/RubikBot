namespace RubikBot.Model.Geometry
{
    public enum MatrixTemplate
    {
        RotoateX90AntiClockWise = 1,
        RotoateX90ForwardClockWise = 2,
        RotoateY90AntiClockWise = 3,
        RotoateY90ForwardClockWise = 4,
        RotoateZ90AntiClockWise = 5,
        RotoateZ90ForwardClockWise = 6,
    }
    public class Matrix
    {

        public double[,] Elements { get; set; }

        public static Matrix CreateMatrix(MatrixTemplate template, params object[] arguments)
        {
            double[,] elements = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            switch (template)
            {
                case MatrixTemplate.RotoateX90AntiClockWise:
                    elements = new double[,] { { 1, 0, 0 }, { 0, 0, -1 }, { 0, 1, 0 } };
                    break;
                case MatrixTemplate.RotoateX90ForwardClockWise:
                    elements = new double[,] { { 1, 0, 0 }, { 0, 0, 1 }, { 0, -1, 0 } };
                    break;
                case MatrixTemplate.RotoateY90AntiClockWise:
                    elements = new double[,] { { 0, 0, 1 }, { 0, 1, 0 }, { -1, 0, 0 } };
                    break;
                case MatrixTemplate.RotoateY90ForwardClockWise:
                    elements = new double[,] { { 0, 0, -1 }, { 0, 1, 0 }, { 1, 0, 0 } };
                    break;
                case MatrixTemplate.RotoateZ90AntiClockWise:
                    elements = new double[,] { { 0, -1, 0 }, { 1, 0, 0 }, { 0, 0, 1 } };
                    break;
                case MatrixTemplate.RotoateZ90ForwardClockWise:
                    elements = new double[,] { { 0, 1, 0 }, { -1, 0, 0 }, { 0, 0, 1 } };
                    break;
            }

            return new Matrix() { Elements = elements };

        }

        public static Vector operator *(Matrix matrix, Vector vector)
        {
            double i = matrix.Elements[0, 0] * vector.X + matrix.Elements[0, 1] * vector.Y + matrix.Elements[0, 2] * vector.Z;
            double j = matrix.Elements[1, 0] * vector.X + matrix.Elements[1, 1] * vector.Y + matrix.Elements[1, 2] * vector.Z;
            double k = matrix.Elements[2, 0] * vector.X + matrix.Elements[2, 1] * vector.Y + matrix.Elements[2, 2] * vector.Z;
            return new Vector(i, j, k);

        }
    }
}
