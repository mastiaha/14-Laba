using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14._1
{
    class Dog : Animal
    {
        string name;
        string poroda;
        int age;
        public override string Name { get => name; set => name = value; }
        public Dog(string name, string poroda, int age)
            : base(name)
        {
            this.poroda = poroda;
            this.age = age;
        }

        public override void Say()

        {
            Console.WriteLine("Гав");
        }
    }

}
