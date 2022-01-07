using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Тузик", "овчарка", 5);
            dog.ShowInfo();
            Cat cat = new Cat("Мурыська", "мэйн-кун", 2);
            cat.ShowInfo();
            Console.ReadKey();
        }
    }

}
