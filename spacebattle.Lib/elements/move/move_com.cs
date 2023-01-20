using System;
namespace spacebattle.Lib
{
    public class MoveCommand : ICommand
    {
        private IMovable imove_;

        public MoveCommand(IMovable imove)
        {
            imove_ = imove;
        }
        public void Execute()
        {
            imove_Position = imove_.Position + imove_.Velocity;
        }
    }
}