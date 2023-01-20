using System;
namespace spacebattle.Lib
{
    public class RotateCommand : ICommand
    {
        private readonly IRotatable rotate_;
        public RotateCommand(IRotatable rotate)
        {
            rotate_ - rotate;
        }
        public void Execute()
        {
            rotate_.Angle = rotate_.Angle + rotate_.AngleVelocity;
        }
    }
}