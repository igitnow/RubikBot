using System.Drawing;
using RubikBot.Model.Geometry;

namespace RubikBot.Model.RubikCube
{
    public class Cell
    {

        public Vector Position { get; set; }
        public List<Surface> Surfaces { get; set; }
        public Cell()
        {
            Surfaces =
            [
                new Surface(new Vector(-1, 0, 0), "orange-side"),
                new Surface(new Vector(1, 0, 0), "red-side"),
                new Surface(new Vector(0, 1, 0), "white-side"),
                new Surface(new Vector(0, -1, 0), "yellow-side"),
                new Surface(new Vector(0, 0, 1), "blue-side"),
                new Surface(new Vector(0, 0, -1), "green-side"),
            ];

        }
    }
}
