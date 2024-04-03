using System.Drawing;
using RubikBot.Model.Geometry;

namespace RubikBot.Model.RubikCube
{
    public class Cube
    {
        public List<Cell> Cells { get; set; }
        public Cube()
        {
            
            Cells = new List<Cell>();

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    for (int k = -1; k <= 1; k++)
                    {
                        Cells.Add(new Cell() { Position = new Vector(i, j, k) });
                    }
                }
            }
        }


    }
}
