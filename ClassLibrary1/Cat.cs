using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _age;
        private string _name;
        public string CurrentColor { get; set; }
        public CatColor Color { get; set; }

        public Cat(CatColor color)
        {
            Color = color;
            CurrentColor = color.HealthyColor;
        }
        public string Age
        {
            get { return _age; }
            set
            {
                if (string.IsNullOrEmpty(_age))
                {
                    _age = value;
                }
            }

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
        public void SetCurrentColor()
        {
            CurrentColor = _health< 5 ? Color.SickColor : Color.HealthyColor;
        }
    }
}
