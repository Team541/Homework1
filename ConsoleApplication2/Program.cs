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

            int caseSwitch;
            do
            {
                Console.Write("Возраст кошки: " + cat.Age + "\nИмя кошки: " + cat.Name + "\nЦвет кошки: " + cat.CurrentColor);
                Console.Write("\nМеню \n1.Выбрать имя кошки \n2.Выбрать цвет здоровой кошки. \n3.Выбрать цвет больной кошки. \n4.Покормить кошку. \n5.Наказать кошку. \n6.Выход\n");
                caseSwitch = int.Parse (Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Введите имя кошки:\n");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите цвет здоровой кошки:\n");
                        color.HealthyColor = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите цвет больной кошки:\n");
                        color.SickColor = Console.ReadLine();
                        break;
                    case 4:
                        cat.Feed();
                        break;
                    case 5:
                        cat.Punish();
                        break;
                    case 6:
                        break;                                                  
                }
            } while (caseSwitch != 6);
        }
    }
}
