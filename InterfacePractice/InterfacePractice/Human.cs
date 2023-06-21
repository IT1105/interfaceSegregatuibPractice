using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Human : IAnimal,ISwimAnimals
    {
        public void MoveHuman()
        {
            eat();
            sleep();
            swim();
        }
        public void eat()
        {
            throw new NotImplementedException();
        }
        public void sleep()
        {
            throw new NotImplementedException();
        }

        public void swim()
        {
            throw new NotImplementedException();
        }
    }
}
