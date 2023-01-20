using Hwdtech;
using Hwdtech.Ioc;
namespace SpaceBattle.Lib 
{
    public class CollisionCheck : ICommand
    {
        private readonly IUObject ob1, ob2;
        public CollisionCheck(IUObject _ob1, IUObject _ob2)
        {
            this.ob1 = _ob1;
            this.ob2 = _ob2;
        }
        public void Execute()
        {   
            var dlist = IoC.Resolve<IEnumerable<int>>("Collision.GetDeltas", ob1, ob2);
            if (IoC.Resolve<bool>("Collision.CheckWithTree", dlist)) 
            {
                throw new Exception("Collision");
            }
        }
    }
}