using System;
namespace SpaceBattle.Lib {
    public interface IMoveCommandStartable
    {
        IUObject uobject { get; }
        Vector velocity { get; }
        Queue<ICommand> queue { get; }
    }
}