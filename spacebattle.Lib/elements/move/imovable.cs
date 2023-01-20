using system;
namespace spacebattle.Lib
{
    public interface IMovable
    {
        public Vector Position { get; set; }
        public Vector Velocity { get; }
    }
}