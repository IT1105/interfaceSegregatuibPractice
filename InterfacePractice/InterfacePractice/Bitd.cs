﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Bird : IAnimal,ISwimAnimals
    {
        public void eat()
        {
            // 食事をする処理
        }

        public void sleep()
        {
            // 眠る処理
        }
        public void swim()
        {
            // 泳ぐ処理
        }
    }
}
