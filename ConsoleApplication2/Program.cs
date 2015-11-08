using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View

{
    class Program
    {
        static void Main(string[] args)
        {
            var color = new CatColor();
            string Age;
            
            Console.WriteLine("Вы купили кошку.\n");
            Console.WriteLine("Введите возраст кошки:");
            Age = Console.ReadLine();
            var cat = new Cat(color, Age);
            Console.WriteLine("Введите имя кошки");
            cat.Name = Console.ReadLine();

            int caseSwitch;
            do
            {
                Console.Write("Возраст кошки: " + cat.Age + "\nИмя кошки: " + cat.Name + "\nЦвет кошки: " + cat.CurrentColor);
                Console.Write("\nМеню \n1.Выбрать цвет здоровой кошки. \n2.Выбрать цвет больной кошки. \n3.Покормить кошку. \n4.Наказать кошку. \n5.Выход\n");
                caseSwitch = int.Parse (Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.Write("Введите цвет здоровой кошки\n");
                        color.HealthyColor = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите цвет больной кошки\n");
                        color.SickColor = Console.ReadLine();
                        break;
                    case 3:
                        cat.Feed();
                        break;
                    case 4:
                        cat.Punish();
                        break;
                    case 5:
                        break;                                                  
                }
            } while (caseSwitch != 5);
        }
    }
}
