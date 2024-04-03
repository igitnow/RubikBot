using RubikBot.Model.Geometry;

namespace RubikBot.Model.RubikCube
{
    public class CubePresentation
    {
        public CubePresentation(Cube cube)
        {

            //X+ Side


            XPlus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(1, -1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;

            
            XPlus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(1, 0, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(1, 0, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 0, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;

            XPlus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(1, 1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;
            XPlus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(1, 0, 0)).FirstOrDefault().StyleClass;

            //X- Side
            XMinus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;

            XMinus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, 0, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(-1, 0, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 0, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;

            XMinus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;
            XMinus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(-1, 0, 0)).FirstOrDefault().StyleClass;


            //Y+ Side
            YPlus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;

            YPlus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;

            YPlus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;
            YPlus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 1, 0)).FirstOrDefault().StyleClass;

            //Y- Side
            YMinus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;

            YMinus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(0, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(0, -1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(0, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;

            YMinus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(1, -1, 0)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;
            YMinus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, -1, 0)).FirstOrDefault().StyleClass;


            //Z+ Side
            ZPlus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(0, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(1, -1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;

            ZPlus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, 0, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 0, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(1, 0, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;

            ZPlus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;
            ZPlus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(1, 1, 1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, 1)).FirstOrDefault().StyleClass;

            //Z- Side
            ZMinus[2, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[2, 1] = cube.Cells.Where(a => a.Position == new Vector(0, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[2, 2] = cube.Cells.Where(a => a.Position == new Vector(1, -1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;

            ZMinus[1, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 0, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[1, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 0, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[1, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 0, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;

            ZMinus[0, 0] = cube.Cells.Where(a => a.Position == new Vector(-1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[0, 1] = cube.Cells.Where(a => a.Position == new Vector(0, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;
            ZMinus[0, 2] = cube.Cells.Where(a => a.Position == new Vector(1, 1, -1)).FirstOrDefault().Surfaces.Where(b => b.Normal == new Vector(0, 0, -1)).FirstOrDefault().StyleClass;

        }
        
        public string[,] XPlus{ get; set; } = new string[3, 3];
        public string[,] XMinus { get; set; } = new string[3, 3];
        public string[,] YPlus { get; set; } = new string[3, 3];
        public string[,] YMinus { get; set; } = new string[3, 3];
        public string[,] ZPlus { get; set; } = new string[3, 3];
        public string[,] ZMinus { get; set; } = new string[3, 3];
    }
}
