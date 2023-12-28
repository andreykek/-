using Hwdtech;
using Hwdtech.Ioc;
namespace SpaceBattle.Lib
public class StartMoveCommand : ICommand
{
    private IMoveCommandStartable startcom;

    public StartMoveCommand(IMoveCommandStartable _startcom)
    {
        this.startcom = _startcom;
    }
    public void Execute()
    {
        IoC.Resolve<ICommand>("Object.SetProperty", startcom.uObject, "velocity", startcom.velocity).Execute();
        var movecom = IoC.Resolve<ICommand>("Command.Move", startcom.uObject);
        IoC.Resolve<ICommand>("Queue.Push", startcom.queue, movecom).Execute();
    }
}