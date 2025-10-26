using System;

namespace AdvancedClass
{
    class Program
    {
        private int _gas;
        private int _speed;
        public void Main(string[] args)
        {
            float result = 0.0f;
            //Boom, Main method has instantiated the Car class.
            Car myCar = new Car();
            myCar.CheckDash(out _gas, out _speed);
        }
    }
}

