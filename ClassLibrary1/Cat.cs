using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private readonly string _age;
        private string _name;
        public CatColor Color { get; set; }

        public Cat(CatColor color, string Age)
        {
            Color = color;
            _age = Age;
        }
        public string Age
        {
            get { return _age; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }
        private int _health = 5;

        public void Feed()
        {
            ++_health;
        }
        public void Punish()
        {
            --_health;
        }
        public string CurrentColor
        {
            get
            {
                return _health < 5 ? Color.SickColor : Color.HealthyColor;
            }
        }
    }
}
