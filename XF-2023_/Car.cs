using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_2023_
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public Car(string nameName,string colorName,int yearValue,int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " IS GOING AT THE SPEED OF " + maxSpeed);
        }
    }
}
