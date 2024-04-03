using RubikBot.Model.Geometry;

namespace RubikBot.Model.RubikCube
{
    public enum Direction
    {
        NotSet = 0,
        AntiClockWise = 1,
        ForwardClockWise = 2
    }

    public enum CommandStatus
    {
        Invalid = 0,
        Valid = 1
    }
    public class RubikCommand
    {

        public RubikCommand(Plane plane, Direction direction)
        {
            Plane = plane;
            Direction = direction;
        }

        public Plane Plane { get; set; }
        public Direction Direction { get; set; }

        public static List<string> CommandList = new List<string>() { "F", "R'", "U", "B'", "L", "D'" };
        public static RubikCommand FromText(string textCommand)
        {

            switch (textCommand.ToUpper().Trim())
            {
                case "F":
                    return new RubikCommand(new Plane(new Vector(0, 0, 1), new Vector(0, 0, -1)), Direction.ForwardClockWise);
                case "R'":
                    return new RubikCommand(new Plane(new Vector(1, 0, 0), new Vector(1, 0, 0)), Direction.ForwardClockWise);
                case "U":
                    return new RubikCommand(new Plane(new Vector(0, 1, 0), new Vector(0, 1, 0)), Direction.ForwardClockWise);
                case "B'":
                    return new RubikCommand(new Plane(new Vector(0, 0, 1), new Vector(0, 0, 1)), Direction.AntiClockWise);
                case "L":
                    return new RubikCommand(new Plane(new Vector(1, 0, 0), new Vector(-1, 0, 0)), Direction.AntiClockWise);
                case "D'":
                    return new RubikCommand(new Plane(new Vector(0, 1, 0), new Vector(0, -1, 0)), Direction.AntiClockWise);
                default:
                    throw new Exception("Rubik textCommand not recognized.");

            }



        }

    }
}
