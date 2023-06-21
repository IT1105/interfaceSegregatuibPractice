using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacePractice
{
    public interface IAnimal
    {
        void eat();
        void sleep();
    }
    public interface ISwimAnimals
    {
        void swim();
    }
    public interface IFlyAnimals
    {
        void fly();
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.MoveHuman();

        }
    }
}
