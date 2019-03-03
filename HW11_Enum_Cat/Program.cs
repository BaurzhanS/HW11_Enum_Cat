using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Enum_Cat
{
    public enum Food { fly=1,mouse,fish,kiticat}
    public class Cat
    {
        public string Name { get; set; }
        public int FullnessLevel { get; private set; }
        public Cat(string name)
        {
            Name = name;
        }
        public void Eat(Food food=0)
        {
            FullnessLevel = (int)food;
            if (FullnessLevel == 0)
                Console.WriteLine("Кошка нифига не ела!");
            else if(FullnessLevel==1)
                Console.WriteLine("Кошка голодная, муха не еда!");
            else if (FullnessLevel == 2)
                Console.WriteLine("Кошка поела, но не наелась!");
            else if (FullnessLevel == 3)
                Console.WriteLine("Кошка поела и почти наелась!");
            else if (FullnessLevel == 4)
                Console.WriteLine("Кошка наелась!");
            else
                Console.WriteLine("Кошка переела и умерла!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Тузик");
            c.Eat(Food.kiticat);
            c.Eat((int)Food.kiticat+Food.fly);
        }
    }
}
