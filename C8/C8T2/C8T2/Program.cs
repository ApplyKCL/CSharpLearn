using System;

namespace C8T2
{

    class Tank
    {
        static int _water = 0;
        static int _maxWater = 1000;
        
        public void Fill(int amount)
        {
            if(_water + amount > _maxWater)
            {
                _water = _maxWater;
            }
            else
            {
                _water += amount;
            }
        }
        public void Leak(int amount)
        {
            if(_water < amount)
            {
                _water = 0;
            }
            else
            {
                _water -= amount;
            }
        }
        
        public int GetWater()
        {
            return _water;
        }
        
    }

    class Program
    {
        
        Tank tank = new Tank();
        
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.Fill(100);
            Console.WriteLine(tank.GetWater());
            tank.Leak(50);
            Console.WriteLine(tank.GetWater());
            tank.Leak(100);
            Console.WriteLine(tank.GetWater());
        }
    }
}