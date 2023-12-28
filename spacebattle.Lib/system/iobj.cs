using System;
namespace SpaceBattle.Lib 
{
    public interface IUObject
    {
        public object getProperty(string a);
        public void setProperty(string a, object b);
    }
}