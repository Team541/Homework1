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
            var cat = new Cat(color);

            int caseSwitch;
            do
            {
                cat.SetCurrentColor();
                Console.Write("Возраст кошки: " + cat.Age + "\nИмя кошки: " + cat.Name + "\nЦвет кошки: " + cat.CurrentColor);
                Console.Write("\nМеню \n1.Покупка кошки. \n2.Выбрать цвет кошки. \n3.Покормить кошку. \n4.Наказать кошку. \n5.Выход\n");
                caseSwitch = int.Parse (Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Введите возраст кошки:");
                        cat.Age = Console.ReadLine();
                        Console.WriteLine("Введите имя кошки");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Выбрать цвет здоровой кошки\n");
                        color.HealthyColor = Console.ReadLine();
                        Console.Write("Выбрать цвет больной кошки\n");
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
