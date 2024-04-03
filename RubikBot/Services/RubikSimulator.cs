using Microsoft.AspNetCore.Mvc.Rendering;
using RubikBot.Interfaces;
using RubikBot.Model.Geometry;
using RubikBot.Model.RubikCube;
using System.Numerics;

namespace RubikBot.Services
{
    public class RubikSimulator : IRubikSimulator
    {
        public Cube ExecuteCommand(RubikCommand command, Cube cube)
        {
            List<Cell> affectedCells = cube.Cells.Where(a => a.Position.InPlane(command.Plane)).ToList();

            for (int i = 0; i < affectedCells.Count; i++)
            {
                affectedCells[i] = RotateInCube(affectedCells[i], command);
                affectedCells[i] = RotateSelf(affectedCells[i], command);
            }

            return cube;
        }

        private Cell RotateSelf(Cell cell, RubikCommand command)
        {
            for (int i = 0; i<cell.Surfaces.Count; i++)
            {

                switch (command.Direction)
                {
                    case Direction.AntiClockWise:
                        if (Math.Abs(command.Plane.Normal.X) == 1 )
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateX90AntiClockWise) * cell.Surfaces[i].Normal;
                        }
                        else if (Math.Abs(command.Plane.Normal.Y) == 1)
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateY90AntiClockWise) * cell.Surfaces[i].Normal;
                        }
                        else if (Math.Abs(command.Plane.Normal.Z) == 1)
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateZ90AntiClockWise) * cell.Surfaces[i].Normal;
                        }
                        break;
                    case Direction.ForwardClockWise:
                        if (Math.Abs(command.Plane.Normal.X) == 1)
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateX90ForwardClockWise) * cell.Surfaces[i].Normal;
                        }
                        else if (Math.Abs(command.Plane.Normal.Y) == 1)
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateY90ForwardClockWise) * cell.Surfaces[i].Normal;
                        }
                        else if (Math.Abs(command.Plane.Normal.Z) == 1)
                        {
                            cell.Surfaces[i].Normal = Matrix.CreateMatrix(MatrixTemplate.RotoateZ90ForwardClockWise) * cell.Surfaces[i].Normal;
                        }
                        break;
                    default:
                        return null;

                }
            }

            return cell;        
        }
        private Cell RotateInCube(Cell cell, RubikCommand command)
        {
            switch (command.Direction)
            {
                case Direction.AntiClockWise:
                    if (Math.Abs(command.Plane.Normal.X) == 1)
                    { 
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateX90AntiClockWise) * cell.Position; 
                    }
                    else if (Math.Abs(command.Plane.Normal.Y) == 1)
                    {
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateY90AntiClockWise) * cell.Position;
                    }
                    else if (Math.Abs(command.Plane.Normal.Z) == 1)
                    {
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateZ90AntiClockWise) * cell.Position;
                    }
                    break;
                case Direction.ForwardClockWise:
                    if (Math.Abs(command.Plane.Normal.X) == 1)
                    {
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateX90ForwardClockWise) * cell.Position;
                    }
                    else if (Math.Abs(command.Plane.Normal.Y) == 1)
                    {
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateY90ForwardClockWise) * cell.Position;
                    }
                    else if (Math.Abs(command.Plane.Normal.Z) == 1)
                    {
                        cell.Position = Matrix.CreateMatrix(MatrixTemplate.RotoateZ90ForwardClockWise) * cell.Position;
                    }
                    break;
                default:
                    return null;

            }

            return cell;
        }
    }
}
