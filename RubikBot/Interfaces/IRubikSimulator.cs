using RubikBot.Model.RubikCube;

namespace RubikBot.Interfaces
{
    
    public interface IRubikSimulator
    {
        public Cube ExecuteCommand(RubikCommand command, Cube cube);
    }
}
